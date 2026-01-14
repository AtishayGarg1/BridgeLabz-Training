using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Performance
{
    internal class StringConcatenation
    {
        public static void StringConcatComparison()
        {
            int n = 100000;
            Stopwatch sw = new Stopwatch();

            sw.Start();
            string s = "";
            for (int i = 0; i < n; i++)
            {
                s += "a";
            }
            sw.Stop();
            Console.WriteLine($"string concat: {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append("a");
            }
            sb.ToString();
            sw.Stop();
            Console.WriteLine($"StringBuilder concat: {sw.ElapsedMilliseconds} ms");
            Console.WriteLine();
        }

    }
}
