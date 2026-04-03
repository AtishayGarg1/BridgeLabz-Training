using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.levelthree
{
    internal class NumberCheckerPalindrome
    {
        static void Main(string[] args)
        {
            //Read a Number
            Console.WriteLine("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Palindrome: " + IsPalindrome(GetDigits(n)));
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

        //Function to check if digits form a Palindrome
        static bool IsPalindrome(int[] d)
        {
            for(int i = 0; i < d.Length / 2; i++)
            {
                if(d[i] != d[d.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
