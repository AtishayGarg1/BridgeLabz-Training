using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.hospitalmanagement
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Program program = new();
            program.Run();
        }

        void Run()
        {
            Doctor doctor1 = new Doctor("Dr. Aman","Cardiology");
            Doctor doctor2 = new Doctor("Dr. Atishay","Neurology");

            Patient[] patients = new Patient[2];
            patients[0] = new InPatient(
                "Ash",
                101,
                doctor1,
                5,
                500
            );
            patients[1] = new OutPatient(
                "Max",
                102,
                doctor2,
                800
            );

            Console.WriteLine("Hospital Management System\n");
            for(int i = 0; i < patients.Length; i++)
            {
                patients[i].DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}
