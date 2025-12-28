using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.builtinstring.levelone
{
    internal class PalindromeChecker
    {
        static void Main(string[] args)
        {
            string s = InputString();
            bool isPalindrome = CheckPalindrome(s);
            DisplayResult(s, isPalindrome);
        }

        // Function to display the result
        public static void DisplayResult(string s, bool IsPalindrome)
        {
            if (IsPalindrome)
            {
                Console.WriteLine(s + " : Is a Palindrome string");
            }
            else
            {
                Console.WriteLine(s + " : Is Not a Palindrome string");
            }
        }

        // Function to take input string from user
        public static string InputString()
        {
            Console.WriteLine("Enter a String to check for Palindrome:");
            string input = Console.ReadLine();
            return input;
        }

        // Function to check if a string is a palindrome
        public static bool CheckPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}
