using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.levelthree
{
    internal class NumberCheckerArmStrong
    {
        static void Main(string[] args)
        {
            //Read a Number
            Console.WriteLine("Enter number: ");
            int n = int.Parse(Console.ReadLine());

            int[] digits = GetDigits(n);
            Console.WriteLine("Digit Count: " + CountDigits(n));
            Console.WriteLine("Duck Number: " + IsDuck(digits));
            Console.WriteLine("Armstrong Number: " + IsArmstrong(n, digits));
        }

        //Function to count digits in a number
        static int CountDigits(int n)
        {
            return n.ToString().Length;
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

        //Function to check if number is Duck Number
        static bool IsDuck(int[] d)
        {
            foreach(int x in d)
            {
                if(x == 0)
                {
                    return true;
                } 
            }
            return false;
        }

        //Function to check if number is Armstrong Number
        static bool IsArmstrong(int n, int[] d)
        {
            int p = d.Length, sum = 0;
            foreach(int x in d)
            {
                sum += (int)Math.Pow(x, p);
            }
            return sum == n;
        }
    }
}
