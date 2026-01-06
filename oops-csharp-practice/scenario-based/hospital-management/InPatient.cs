using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.hospitalmanagement
{
    internal class InPatient : Patient, IPayable
    {
        private int daysAdmitted;
        private double dailyCharge;

        public InPatient(string name, int id, Doctor doctor, int daysAdmitted, double dailyCharge) : base(name, id, doctor)
        {
            this.daysAdmitted = daysAdmitted;
            this.dailyCharge = dailyCharge;
        }

        public double CalculateBill()
        {
            return daysAdmitted * dailyCharge;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("In Pateient | ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Days Admitted: " + daysAdmitted);
            Console.WriteLine(doctor.GetDoctorInfo());
            Console.WriteLine("Total Bill: "+ CalculateBill());

        }

    }
}
