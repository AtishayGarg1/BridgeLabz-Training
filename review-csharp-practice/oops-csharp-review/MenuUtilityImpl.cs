using System;
using System.Collections.Generic;
using System.Text;

namespace Review.oops_review
{
    internal class MenuUtilityImpl : IMenu
    {
        private FoodMenu[] FoodMenus;
        private FoodMenu[] FoodOrdered;
        private int Capacity = 10;
        private int TotalPrice = 0;
        private int count = 0;
        private int countOrdered = 0;

        public MenuUtilityImpl()
        {
            FoodMenus = new FoodMenu[Capacity];
            FoodOrdered = new FoodMenu[100];
        }

        public void AddFood()
        {
            FoodMenu foodMenu = new FoodMenu();
            Console.WriteLine("Enter Food Name");
            foodMenu.FoodName1 = Console.ReadLine();
            Console.WriteLine("Enter Food Price");
            foodMenu.FoodPrice1 = int.Parse(Console.ReadLine());

            FoodMenus[count++] = foodMenu;

        }

        public void DisplayMenu()
        {
            for(int i = 0; i < FoodMenus.Length; i++)
            {
                FoodMenu food = FoodMenus[i];
                if(food == null)
                {
                    continue;
                }
                Console.Write(i+1+". ");
                Console.WriteLine(food.ToString());
            }
        }

        public void OrderFood()
        {
            DisplayMenu();
            Console.WriteLine("Select Index From Menu");
            int index = int.Parse(Console.ReadLine()) - 1;
            FoodMenu foodOrdered = FoodMenus[index];
            FoodOrdered[countOrdered++] = foodOrdered;
            TotalPrice += foodOrdered.FoodPrice1;
        }

        public void Bill()
        {
            Console.WriteLine("\nThank You For Visiting");
            Console.WriteLine("Bill");
            Console.WriteLine("-----");
            for(int i = 0; i < countOrdered; i++)
            {
                FoodMenu foodMenu = FoodOrdered[i];
                if(foodMenu == null)
                {
                    continue;
                }
                Console.WriteLine(foodMenu.ToString());
            }
            Console.WriteLine("------");
            Console.Write($"Total Bill: {TotalPrice}");
        }

        public void RemoveItem()
        {
            DisplayMenu();
            Console.WriteLine("Enter Index Of Food Item You want to remove");
            int index = int.Parse(Console.ReadLine()) - 1;
            if(index < 0 || index >= Capacity)
            {
                Console.WriteLine("Invalid Choice");
                return;
            }
            FoodMenus[index] = null;
            count--;
            int c = 0;

            for (int i = 0; i < FoodMenus.Length - 1; i++)
            {
                if (FoodMenus[i] == null)
                {
                    c++;
                    FoodMenus[i] = FoodMenus[i + 1];
                }
                else if(c > 0 && FoodMenus[i] != null)
                {
                    FoodMenus[i] = FoodMenus[i + 1];
                }
            }
        }

        public void DisplayOrderedFood()
        {
            for (int i = 0; i < countOrdered; i++)
            {
                FoodMenu foodMenu = FoodOrdered[i];
                if (foodMenu == null)
                {
                    continue;
                }
                Console.WriteLine(foodMenu.ToString());
            }
        }


    }
}
