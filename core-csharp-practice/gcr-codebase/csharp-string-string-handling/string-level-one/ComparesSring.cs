using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpstring.levelone
{
    internal class ComparesSring
    {
        static void Main(string[] args)
        {
            //Read two strings from the user
            Console.WriteLine("Enter Two Strings");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            bool result = CompareTwoString(str1, str2);
            bool expected = str1.Equals(str2);
            if (result == expected)
            {
                Console.WriteLine("Strings are Equal");
            }
            else
            {
                Console.WriteLine("Strings are not Equal");
            }
        }

        //Function to compare two strings character by character
        public static bool CompareTwoString(string str1, string str2)
        {
            for (int i = 0; i < str1.Length && i < str2.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
