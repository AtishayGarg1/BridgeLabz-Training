using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.leveltwo
{
    internal class BMIIndex
    {
        static void Main(string[] args)
        {
            //Array to store weight, height and BMI for 10 People
            double[,] data = new double[10, 3];
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter weight (kg): ");
                data[i, 0] = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter height (cm): ");
                data[i, 1] = double.Parse(Console.ReadLine());

                data[i, 2] = CalculateBMI(data[i, 0], data[i, 1]);
            }
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("BMI: "+data[i, 2]+", Status: "+GetBMIStatus(data[i, 2]));
            }
        }

        //Function to calculate BMI Index
        static double CalculateBMI(double weight, double heightCm)
        {
            double heightMeters = heightCm / 100;
            return weight / (heightMeters * heightMeters);
        }

        //Function to get BMI Status
        static string GetBMIStatus(double bmi)
        {
            if(bmi < 18.5)
            {
                return "Underweight";
            }
            if(bmi < 25)
            {
                return "Normal";
            } 
            if(bmi < 30)
            {
                return "Overweight";
            } 
            return "Obese";
        }
    }
}
