using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.BrowserBuddy
{
    internal class BrowserHistory
    {
        public HistoryNode current;

        public void Visit(string url)
        {
            HistoryNode newNode = new HistoryNode(url);

            if (current != null)
            {
                current.Next = null; // clear forward history
                newNode.Prev = current;
                current.Next = newNode;
            }

            current = newNode;
            Console.WriteLine($"Visited: {url}");
        }

        public void Back()
        {
            if (current?.Prev == null)
            {
                Console.WriteLine("No back history.");
                return;
            }

            current = current.Prev;
            Console.WriteLine($"Back to: {current.Url}");
        }

        public void Forward()
        {
            if (current?.Next == null)
            {
                Console.WriteLine("No forward history.");
                return;
            }

            current = current.Next;
            Console.WriteLine($"Forward to: {current.Url}");
        }

        public string GetCurrent()
        {
            return current == null ? "Empty Tab" : current.Url;
        }
    }
}
