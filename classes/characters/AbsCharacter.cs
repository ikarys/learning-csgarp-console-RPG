using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTutoRPG.classes
{
    abstract class AbsCharacter
    {
        public int life;
        public bool alive = true;
        public string? name;

        public int Life { 
            get => life;
            set { life = value; } 
        }

        public bool IsAlive()
        {
            if (alive) return true;
            return false;
        }

        public void TakeDamages(int damages)
        {
            life -= damages;
        }
    }
}
