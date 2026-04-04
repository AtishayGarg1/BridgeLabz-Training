using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.levelthree
{
    internal class OTPGenerator
    {
        static void Main(string[] args)
        {
            //Array To save OTP
            int[] otp = new int[10];
            for(int i = 0; i < 10; i++)
            {
                otp[i] = GenerateOTP();
                Console.WriteLine(otp[i]);
            }
        }

        //Generate a 6 digit OTP
        static int GenerateOTP()
        {
            Random r = new Random();
            return r.Next(100000, 1000000);
        }
    }
}
