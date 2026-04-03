using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.inheritance
{
    
    // Base class
    internal class Course
    {
        // Common attributes
        public string CourseName;
        public int Duration; // in hours

        // Constructor
        public Course(string courseName, int duration)
        {
            CourseName = courseName;
            Duration = duration;
        }

        // Virtual method
        public virtual void DisplayDetails()
        {
            Console.WriteLine("Course Name : " + CourseName);
            Console.WriteLine("Duration    : " + Duration + " hours");
        }
    }

    // Intermediate subclass
    class OnlineCourse : Course
    {
        // Additional attributes
        public string Platform;
        public bool IsRecorded;

        // Constructor chaining using base
        public OnlineCourse(string courseName, int duration, string platform, bool isRecorded)
            : base(courseName, duration)
        {
            Platform = platform;
            IsRecorded = isRecorded;
        }

        // Overriding method
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Platform    : " + Platform);
            Console.WriteLine("Recorded    : " + IsRecorded);
        }
    }

    // Final subclass
    class PaidOnlineCourse : OnlineCourse
    {
        // Additional attributes
        public double Fee;
        public double Discount;

        // Constructor chaining
        public PaidOnlineCourse(
            string courseName,
            int duration,
            string platform,
            bool isRecorded,
            double fee,
            double discount)
            : base(courseName, duration, platform, isRecorded)
        {
            Fee = fee;
            Discount = discount;
        }

        // Overriding method
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Fee         : ₹" + Fee);
            Console.WriteLine("Discount    : " + Discount + "%");
        }
    }

    // Main class
    class Program
    {
        static void Main()
        {
            // Multilevel inheritance demonstration
            Course course =
                new PaidOnlineCourse("C# Full Stack", 120, "Udemy", true, 9999, 20);

            course.DisplayDetails();
        }
    }
}
