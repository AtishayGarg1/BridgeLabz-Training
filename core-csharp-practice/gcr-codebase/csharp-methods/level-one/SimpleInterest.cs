//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BridgeLabzTraining.methods.levelone
//{
//    internal class SimpleInterest
//    {
//        static void Main(string[] args)
//        {
//            //Read Principal, Rate and Time from user
//            Console.WriteLine("Enter Principal amount");
//            double principal = double.Parse(Console.ReadLine());

//            Console.WriteLine("Enter Rate of interest");
//            double rate = double.Parse(Console.ReadLine());

//            Console.WriteLine("Enter Time in years");
//            double time = double.Parse(Console.ReadLine());

//            double simpleInterest = CalculateSimpleInterest(principal, rate, time);
//            Console.WriteLine("Simple Interset: "+simpleInterest);
//        }
//        public static double CalculateSimpleInterest(double principal, double rate, double time)
//        {
//            double simpleInterest = (principal*rate*time) / 100;
//            return simpleInterest;
//        }
//    }
//}
