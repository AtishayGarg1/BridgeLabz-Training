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
            tab1.History.Visit("google.com");
            tab1.History.Visit("github.com");
            tab1.History.Back();
            tab1.History.Forward();

            browser.CloseTab(0);

            Tab restored = browser.RestoreTab();
            Console.WriteLine("Current Page: " + restored.History.GetCurrent());
        }
    }
}
