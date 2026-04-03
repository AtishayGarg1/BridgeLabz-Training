using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.levelone
{
    internal class SpringSeason
    {
        static void Main(string[] args)
        {
            //Read month and day
            int month = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());

            if(IsSpringSeason(month, day))
            {
                Console.WriteLine("Its a Spring Season");
            }
            else
            {
                Console.WriteLine("Not a Spring Season");
            }
        }

        //Check whether it is Spring Season
        static bool IsSpringSeason(int month, int day)
        {
            if((month == 3 && day >= 20) ||
                (month == 4) ||
                (month == 5) ||
                (month == 6 && day <= 20))
                return true;

            return false;
        }
    }
}
