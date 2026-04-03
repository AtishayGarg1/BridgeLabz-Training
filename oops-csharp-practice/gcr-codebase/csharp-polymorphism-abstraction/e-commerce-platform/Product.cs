using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.e_commerce_platform
{
    internal abstract class Product
    {
        private int ProductId;
        private string ProductName;
        private double ProductPrice;

        public int ProductId1 { get => ProductId; set => ProductId = value; }
        public string ProductName1 { get => ProductName; set => ProductName = value; }
        public double ProductPrice1 { get => ProductPrice; set => ProductPrice = value; }

        public abstract double CalculateDiscount();

        public override string? ToString()
        {
            return "\nProduct Name: " + ProductName + "\nProduct Id: " + ProductId + "\nProduct Price: " + ProductPrice+"\nProduct Type: "+this.GetType().Name;
        }
    }
}