using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.BrowserBuddy
{
    internal class Browser
    {
        private Tab[] openTabs;
        private int tabCount;
        private Stack<Tab> closedTabs;

        public Browser(int maxTabs)
        {
            openTabs = new Tab[maxTabs];
            closedTabs = new Stack<Tab>();
            tabCount = 0;
        }

        public Tab OpenTab()
        {
            if (tabCount == openTabs.Length)
            {
                Console.WriteLine("Tab limit reached");
                return null;
            }

            Tab tab = new Tab();
            openTabs[tabCount++] = tab;
            Console.WriteLine("New tab opened");
            return tab;
        }

        public void CloseTab(int index)
        {
            if (index < 0 || index >= tabCount)
            {
                Console.WriteLine("Invalid tab index");
                return;
            }

            closedTabs.Push(openTabs[index]);

            for (int i = index; i < tabCount - 1; i++)
                openTabs[i] = openTabs[i + 1];

            openTabs[--tabCount] = null;
            Console.WriteLine("Tab closed");
        }

        public Tab RestoreLastClosedTab()
        {
            if (closedTabs.Count == 0)
            {
                Console.WriteLine("No tabs to restore");
                return null;
            }

            if (tabCount == openTabs.Length)
            {
                Console.WriteLine("No space to restore tab");
                return null;
            }

            Tab tab = closedTabs.Pop();
            openTabs[tabCount++] = tab;
            Console.WriteLine("Tab restored");
            return tab;
        }
    }
}
