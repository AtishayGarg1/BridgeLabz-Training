using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.OnlineFoodDeliverySystem
{
    internal class Program
    {
        static void Main()
        {
            VegItem vegPizza = new VegItem();
            vegPizza.ItemName = "Veg Pizza";
            vegPizza.Price = 250;
            vegPizza.Quantity = 2;

            NonVegItem chickenBurger = new NonVegItem();
            chickenBurger.ItemName = "Chicken Burger";
            chickenBurger.Price = 180;
            chickenBurger.Quantity = 3;

            FoodItem[] orderItems = new FoodItem[2];
            orderItems[0] = vegPizza;
            orderItems[1] = chickenBurger;

            OrderService.ProcessOrder(orderItems);
        }
    }
}
