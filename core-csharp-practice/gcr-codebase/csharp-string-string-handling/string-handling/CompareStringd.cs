using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.stringhandling
{
    internal class CompareStringd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1'st String");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter 2'nd String");
            string str2 = Console.ReadLine();

            for (int i = 0; i < Math.Min(str1.Length, str2.Length); i++)
            {
                if (str1[i] < str2[i])
                {
                    Console.WriteLine(str1 + " comes before " + str2);
                    return;
                }
                else if (str1[i] > str2[i])
                {
                    Console.WriteLine(str2 + " comes before " + str1);
                    return;
                }
            }
        }
    }
}
