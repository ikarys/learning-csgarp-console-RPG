
using System;
using System.IO;
using System.Text;


using myTutoRPG.classes.characters.player;
using myTutoRPG.classes;

class Test
{
    public static void Main()
    {

        PlayerCharacter p = new PlayerCharacter("Bob", _mana: 200);
        Console.WriteLine("Welcome in our virtual RPG " + p.name + " !");
        Console.WriteLine("You will start with " + p.Life + " points of life and " + p.Mana +" points of mana.");
        Console.WriteLine("Take care, if your points of life reach zero or less, you're DEAD !!");

        Weapon w = new Weapon(
            "Basic sword", 
            _damages_min: 1, 
            _damages_max: 5,
            _fireRate: 0.1,
            _criticRate: 0.15,
            _criticDamagePercent: 5
            );
        Console.WriteLine(w.Name + " makes " + w.CalculDamages() + " pts of damages !");
    }
}