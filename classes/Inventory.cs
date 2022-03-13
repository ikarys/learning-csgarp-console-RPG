using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myTutoRPG;


namespace myTutoRPG.classes
{
    public struct Item
    {
        public string name;
        public string kind;

        public Item(string name, string kind)
        {
            this.name = name;
            this.kind = kind;
        }
    }

    public class Inventory
    {
        Item[] bag = new Item[3];

        public bool AddItemToInventory(Item _item)
        {
            for (int i = 0; i < bag.Length; i++)
            {
                if (bag[i].Equals(default(Item)))
                {
                    bag[i] = _item;
                    ConsoleHelpers.Display("<" + _item.name + "> added to your inventory.", 10);
                    return true;
                }
            }

            ConsoleHelpers.Display(_item.name + "Cannot be added ! Your inventory is full !", 12);
            return false;
        }

        public void OpenInventory()
        {
            ConsoleHelpers.Display("==============================");
            ConsoleHelpers.Display("=          INVENTORY         =");
            ConsoleHelpers.Display("==============================");
            for (int i = 0; i < bag.Length; i++)
            {
                ConsoleHelpers.Display("|| Slot" + i + " | " + bag[i].name + " | ");
            }
            ConsoleHelpers.Display("==============================");
        }
    }
}
