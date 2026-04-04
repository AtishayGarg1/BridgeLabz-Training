/// <summary>
/// Entry point of the Smart Checkout application.
/// Initializes the checkout menu and starts the menu-driven checkout system.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_collections.scenariobased.smarthome
{
    internal class SmartCheckoutMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to checkout system.");
            CheckoutCounterMenu menu = new CheckoutCounterMenu();
            menu.CheckoutMenu();
        }
    }
}
