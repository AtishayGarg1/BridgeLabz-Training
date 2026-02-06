using System;
using System.Collections.Generic;
using System.Text;

namespace Review.oops_review
{
    internal interface IMenu
    {
        void AddFood();
        void DisplayMenu();
        void OrderFood();
        void Bill();
        void RemoveItem();
        void DisplayOrderedFood();
    }
}
