using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTutoRPG.classes
{

    public struct Damages
    {
        int damagesMin;
        int damagesMax;

        public Damages(int _damagesMin, int _damagesMax): this()
        {
            damagesMin = _damagesMin;
            damagesMax = _damagesMax;
        }

        public int DamagesMin { get => damagesMin; }
        public int DamagesMax { get => damagesMax; }
    }

    class Weapon
    {
        string name;

        double fireRate;
        double criticRate;
        int criticDamagePercent = 25;
        Damages damages;

        public Weapon(
            string _name, int _damages_min = 1, int _damages_max = 2, double _fireRate = 0.1, double _criticRate = 0.1, int _criticDamagePercent = 25)
        {
            name = _name;
            damages = new Damages(_damages_min, _damages_max);
            fireRate = _fireRate;
            criticRate = _criticRate;
            criticDamagePercent = _criticDamagePercent;
        }

        public string Name { get => name; }
        public double FireRate { get => fireRate; set => fireRate = value; }
        public double CriticRate { get => criticRate; set => criticRate = value; }
        public int CriticDamagePercent { get => criticDamagePercent; set => criticDamagePercent = value;}

        public int CalculDamages()
        {
            int finalDamages;
            int basicDamages;
            bool isCritic = IsCritic();

            Random rnd = new Random();
            basicDamages = rnd.Next(damages.DamagesMin, damages.DamagesMax + 1 );
            finalDamages = basicDamages;

            if (isCritic)
            {
                int additionalDamages = (criticDamagePercent * basicDamages) / 100;
                Console.WriteLine("Critic damages !! +" + additionalDamages + " points !");
                finalDamages += additionalDamages;
            }
            Console.WriteLine("Final damages : " + finalDamages);
            return finalDamages;
        }

        private bool IsCritic()
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            if (0 <= value && value <= (criticRate * 100))
            {
                return true;
            }
            return false;
        }

    }
}
