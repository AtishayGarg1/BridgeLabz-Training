using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.stringbuilder_search
{
    internal class StringBuilderPerformance
    {
        static void Main()
        {
            StringBuilderPerformance stringBuilderPerformance = new StringBuilderPerformance();
            int iterations = 200_000;

            Console.WriteLine("Performance Comparison\n");

            stringBuilderPerformance.TestNormalString(iterations);
            stringBuilderPerformance.TestStringBuilder(iterations);

            Console.ReadLine();
        }

        void TestNormalString(int count)
        {
            Stopwatch timer = new Stopwatch();
            string result = "";

            timer.Start();

            for (int i = 0; i < count; i++)
            {
                result += "A";
            }

            timer.Stop();

            Console.WriteLine($"String Concatenation Time: {timer.ElapsedMilliseconds} ms");
        }

        void TestStringBuilder(int count)
        {
            Stopwatch timer = new Stopwatch();
            StringBuilder builder = new StringBuilder();

            timer.Start();

            for (int i = 0; i < count; i++)
            {
                builder.Append("A");
            }

            timer.Stop();

            Console.WriteLine($"StringBuilder Time:        {timer.ElapsedMilliseconds} ms");
        }
    }
}
