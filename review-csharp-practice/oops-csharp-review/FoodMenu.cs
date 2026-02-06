using System;
using System.Collections.Generic;
using System.Text;

namespace Review.oops_review
{
    internal class FoodMenu
    {
        private string FoodName;
        private int FoodPrice;

        public string FoodName1 { get => FoodName; set => FoodName = value; }
        public int FoodPrice1 { get => FoodPrice; set => FoodPrice = value; }

        public override string? ToString()
        {
            return $"Food Item: {FoodName} - Price: {FoodPrice}";
        }
    }
}
