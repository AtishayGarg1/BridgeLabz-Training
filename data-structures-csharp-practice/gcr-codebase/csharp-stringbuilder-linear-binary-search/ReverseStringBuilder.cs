using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.stringbuilder_search
{
    internal class ReverseStringBuilder
    {
        public void Reverse()
        {
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            int index = str.Length - 1;
            while (index >= 0)
            {
                sb.Append(str[index--]);
            }
            Console.Write("Reversed String: " + sb.ToString());
        }
        static void Main(string[] args)
        {
            ReverseStringBuilder reverseStringBuilder = new ReverseStringBuilder();
            reverseStringBuilder.Reverse();
        }
    }
}
