using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.OnlineFoodDeliverySystem
{
    internal abstract class FoodItem
    {
        protected string itemName;
        protected double price;
        protected int quantity;

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value > 0)
                    quantity = value;
            }
        }

        public abstract double CalculateTotalPrice();

        public void GetItemDetails()
        {
            Console.WriteLine($"Item: {ItemName}, Price: {Price}, Quantity: {Quantity}");
        }
    }
}
