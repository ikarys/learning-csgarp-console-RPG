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

        public PlayerCharacter(string _name, int _life = 100, int _mana = 100)
        {
            name = _name;
            life = _life;
            mana = _mana;
        }

        public int Mana
        {
            get => mana;
            set => mana = value;
        }
    }
}
