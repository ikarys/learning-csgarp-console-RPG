using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myTutoRPG;


namespace myTutoRPG.classes
{
    abstract class AbsCharacter
    {
        public int maxLife = 100;
        public int life;
        public bool alive = true;
        public string? name;

        public int Life {
            get => life;
            set { life = value; } 
        }

        public int GetLife()
        {
            ConsoleHelpers.Display("You have " + life + " pts of life.");
            return life;
        }


        public bool IsAlive()
        {
            if (alive) return true;
            return false;
        }

        public void TakeDamages(int damages)
        {
            life -= damages;
            
            ConsoleHelpers.Display("=> You take " + damages + " damages !!", 12);
            

            if (life <= 0)
            {
                life = 0;
            };
        }

        public void Heal(int nbHeal)
        {
            life += nbHeal;
            ConsoleHelpers.Display("=> You're healed with " + nbHeal, 10);

            if (life > maxLife)
            {
                life = maxLife;
            }
        }

    }
}
