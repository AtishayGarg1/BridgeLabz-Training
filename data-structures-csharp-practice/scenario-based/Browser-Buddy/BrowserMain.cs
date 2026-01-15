using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.BrowserBuddy
{
    internal class BrowserMain
    {
        static void Main(string[] args)
        {
            Browser browser = new Browser(5);

            Tab tab1 = browser.OpenTab();
            tab1.Visit("google.com");
            tab1.Visit("github.com");
            tab1.Back();
            tab1.Forward();

            browser.CloseTab(0);

            Tab restored = browser.RestoreLastClosedTab();
            Console.WriteLine("Current page: " + restored.History.CurrentPage());
        }
    }
}
