using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.levelthree
{
    internal class NumberCheckerHarshad
    {
        static void Main(string[] args)
        {
            //Read a Number
            Console.WriteLine("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            int[] d = GetDigits(n);

            Console.WriteLine("Sum of Digits: " + SumDigits(d));
            Console.WriteLine("Harshad Number: " + IsHarshad(n, d));
        }

        //Function to get digits of a number
        static int[] GetDigits(int n)
        {
            string s = n.ToString();
            int[] d = new int[s.Length];
            for(int i = 0; i < s.Length; i++)
            {
                d[i] = int.Parse(s[i].ToString());
            }
            return d;
        }

        //Function to sum digits of a number
        static int SumDigits(int[] d)
        {
            int s = 0;
            foreach(int x in d)
            {
                s += x;
            } 
            return s;
        }

        //Function to check if number is Harshad
        static bool IsHarshad(int n, int[] d)
        {
            return n % SumDigits(d) == 0;
        }
    }
}
