using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Constructors
{
    internal class OnlineCourse
    {
        // Instance variables
        public string courseName;
        public int duration;
        public int fees;

        // Static variable shared by all objects
        public static string instituteName = "BridgeLabz";

        // Parameterized constructor
        public OnlineCourse(string courseName, int duration, int fees)
        {
            this.courseName = courseName;
            this.duration = duration;
            this.fees = fees;
        }

        // Method to display course details
        public void DisplayCourse()
        {
            Console.WriteLine("Course by: " + instituteName);
            Console.WriteLine("Course name: " + courseName);
            Console.WriteLine("Duration: " + duration);
            Console.WriteLine("Fees: " + fees);
        }

        // Static method to update institute name
        public static void UpdateInstituteName(string instituteName)
        {
            OnlineCourse.instituteName = instituteName;
        }
    }

    // Main execution class
    class run
    {
        static void Main(string[] args)
        {
            OnlineCourse obj1 = new("C#", 135, 10000);
            obj1.DisplayCourse();

            Console.WriteLine("Update Istitute Name ");
            string institute = Console.ReadLine();
            OnlineCourse.UpdateInstituteName(institute);

            OnlineCourse obj2 = new("Java", 120, 8000);
            obj2.DisplayCourse();
        }
    }
}
