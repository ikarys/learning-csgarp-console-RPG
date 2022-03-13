using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using myTutoRPG.classes;


namespace myTutoRPG.classes.characters.player
{
    class PlayerCharacter : AbsCharacter
    {
        int mana;
        Weapon? mainWeapon;
        Inventory inventory;

        public PlayerCharacter(string _name, int _life = 100, int _mana = 100)
        {
            name = _name;
            life = _life;
            mana = _mana;
            inventory = new Inventory();
        }

        public Inventory Inventory { get { return inventory; } }

        public void SetWeapon(Weapon _weapon)
        {
            this.mainWeapon = _weapon;
        }

        public string GetWeapon()
        {
            if (this.mainWeapon == null)
            {
                return "";
            }

            return this.mainWeapon.Name;
        }

        public int Mana
        {
            get => mana;
            set => mana = value;
        }
    }
}
