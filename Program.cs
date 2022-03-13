
using System;
using System.IO;
using System.Text;


using myTutoRPG.classes.characters.player;
using myTutoRPG.classes;
using myTutoRPG;

class Test
{
    public static void Main()
    {

        PlayerCharacter p = new PlayerCharacter("Bob", _mana: 200);
        ConsoleHelpers.Display("Welcome in our virtual RPG " + p.name + " !");
        ConsoleHelpers.Display("You will start with " + p.Life + " points of life and " + p.Mana +" points of mana.");
        ConsoleHelpers.Display("Take care, if your points of life reach zero or less, you're DEAD !!");

        Console.WriteLine("----------------------------------------------------------------------------");
        Weapon w = new Weapon(
            "Basic sword", 
            _damages_min: 1, 
            _damages_max: 5,
            _fireRate: 0.1,
            _criticRate: 0.15,
            _criticDamagePercent: 5
            );

        p.SetWeapon(w);
        ConsoleHelpers.Display("=> You get new weapon: <" + p.GetWeapon() + ">", 11);
        p.TakeDamages(25);
        p.GetLife();
        p.Heal(10);
        p.GetLife();

        Item i1 = new Item("Fish", "Consumable");
        Item i2 = new Item("Meat", "Consumable");
        Item i3 = new Item("Potion", "Consumable");
        Item i4 = new Item("Boom", "Consumable");
        p.Inventory.AddItemToInventory(i1);
        p.Inventory.AddItemToInventory(i2);
/*        p.Inventory.AddItemToInventory(i3);
        p.Inventory.AddItemToInventory(i4);*/
        p.Inventory.OpenInventory();
    }
}