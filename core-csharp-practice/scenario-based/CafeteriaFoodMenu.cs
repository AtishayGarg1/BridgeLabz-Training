using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased
{
    internal class CafeteriaFoodMenu
    {
        static void Main(string[] args)
        {
            string[] menuItems =
            {
            "Idli",
            "Dosa",
            "Vada",
            "Upma",
            "Poha",
            "Fried Rice",
            "Veg Curry",
            "Chapati",
            "Tea",
            "Coffee"
        };

            DisplayMenu(menuItems);

            Console.Write("\nEnter the item index you want to order: ");
            int index = Convert.ToInt32(Console.ReadLine());

            string selectedItem = GetItemByIndex(menuItems, index);

            if (selectedItem != null)
            {
                Console.WriteLine("You have ordered: " + selectedItem);
            }
            else
            {
                Console.WriteLine("Invalid selection. Please choose a valid index.");
            }
        }

        // Displays the cafeteria menu
        static void DisplayMenu(string[] items)
        {
            Console.WriteLine("Campus Cafeteria Menu:");

            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(i + ". " + items[i]);
            }
        }

        // Returns item based on index
        static string GetItemByIndex(string[] items, int index)
        {
            if (index >= 0 && index < items.Length)
            {
                return items[index];
            }
            return null;
        }
    }
}
