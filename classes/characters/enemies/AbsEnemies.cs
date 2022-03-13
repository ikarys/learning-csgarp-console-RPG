using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myTutoRPG.classes;

using myTutoRPG.classes.characters.player;

namespace myTutoRPG.classes.characters.enemies
{
    class AbsEnemies : AbsCharacter
    {

        public AbsEnemies (string _name)
        {
            name = _name;
        }

        public static void Attack(PlayerCharacter player, int damages)
        {
            player.TakeDamages(damages);
        }
    }
}
