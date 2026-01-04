using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.thisstatic
{
    internal class HospitalManagementSystem
    {
        // Static variable
        public static string hospitalName = "City Hospital";

        // Static variable to count total patients
        private static int totalPatients = 0;

        // Readonly variable
        public readonly int patientId;

        // Instance variables
        public string name;
        public int age;
        public string ailment;

        // Constructor using this keyword
        public HospitalManagementSystem(int patientId, string name, int age, string ailment)
        {
            this.patientId = patientId;
            this.name = name;
            this.age = age;
            this.ailment = ailment;
            totalPatients++;
        }

        // Static method to display total patients
        public static void GetTotalPatients()
        {
            Console.WriteLine("Total Patients: " + totalPatients);
        }

        // Display patient details using is operator
        public void DisplayDetails(object obj)
        {
            if (obj is HospitalManagementSystem)
            {
                Console.WriteLine("Hospital : " + hospitalName);
                Console.WriteLine("Patient ID : " + patientId);
                Console.WriteLine("Name       : " + name);
                Console.WriteLine("Age        : " + age);
                Console.WriteLine("Ailment    : " + ailment);
            }
            else
            {
                Console.WriteLine("Invalid patient object");
            }
        }
    }

    class run
    {
        static void Main(string[] args)
        {
            // Create patient object
            HospitalManagementSystem p1 =
                new HospitalManagementSystem(1, "Atishay Garg", 21, "Fever");

            p1.DisplayDetails(p1);
            Console.WriteLine();

            HospitalManagementSystem.GetTotalPatients();
        }
    }
}
