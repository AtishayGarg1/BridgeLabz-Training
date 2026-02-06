using System;
using System.Collections.Generic;
using System.Text;

namespace Review.oops_review
{
    sealed class CafeteriaMenu
    {
        IMenu Menu;

        public CafeteriaMenu()
        {
            Menu = new MenuUtilityImpl();
        }

        public void CafeteriaFoodMenu()
        {
            Console.WriteLine("Welcome to Bridge-Labz Cafeteria");
            while (true)
            {
                Console.WriteLine("1. Add Food Item");
                Console.WriteLine("2. Remove Food Item");
                Console.WriteLine("3. Display All Food Items");
                Console.WriteLine("4. Order Food");
                Console.WriteLine("5. Display Food Items Ordered");
                Console.WriteLine("6. Display Bill");
                Console.WriteLine("7. Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Menu.AddFood();
                        break;
                    case 2:
                        Menu.RemoveItem();
                        break;
                    case 3:
                        Menu.DisplayMenu();
                        break;
                    case 4:
                        Menu.OrderFood();
                        break;
                    case 5:
                        Menu.DisplayOrderedFood();
                        break;
                    case 6:
                        Menu.Bill();
                        break;
                    case 7:
                        Menu.Bill();
                        return;
                    default:
                        break;
                }
            }
        }

    }
}
