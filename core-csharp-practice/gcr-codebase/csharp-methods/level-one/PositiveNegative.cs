using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.levelone
{
    internal class PositiveNegative
    {
        static void Main(string[] args)
        {
            //Read a number
            Console.WriteLine("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());
            int result = CheckNumber(num);
            //Display the result
            if (result == 1)
                Console.WriteLine("Positive Number");
            else if (result == -1)
                Console.WriteLine("Negative Number");
            else
                Console.WriteLine("Zero");
        }

        //Check whether the number is positive, negative or zero
        static int CheckNumber(int number)
        {
            if (number > 0) return 1;
            if (number < 0) return -1;
            return 0;
        }
    }
}
