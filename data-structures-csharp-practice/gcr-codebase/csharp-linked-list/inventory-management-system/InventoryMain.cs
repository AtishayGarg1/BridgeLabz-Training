using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.inventorymanagementsystem
{
    internal class InventoryMain
    {
        static void Main(string[] args)
        {
            InventoryManagement inventory = new InventoryManagement();

            inventory.AddAtEnd(1, "Laptop", 5, 60000);
            inventory.AddAtEnd(2, "Mouse", 20, 500);
            inventory.AddAtEnd(3, "Keyboard", 10, 1500);

            inventory.DisplayAllItems();

            inventory.AddAtPosition(4, "Monitor", 7, 12000, 2);
            inventory.DisplayAllItems();

            inventory.UpdateQuantity(2, 25);
            inventory.SearchByItemId(2);

            inventory.SearchByItemName("Laptop");

            inventory.DisplayTotalInventoryValue();

            inventory.SortByItemName(true);
            inventory.DisplayAllItems();

            inventory.SortByPrice(false);
            inventory.DisplayAllItems();

            inventory.RemoveByItemId(1);
            inventory.DisplayAllItems();
        }
    }
}
