using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.hospitalmanagement
{
    internal class OutPatient : Patient, IPayable
    {
        double consultationFee;
        public OutPatient(string name, int id, Doctor doctor, double consultationFee) : base(name, id, doctor)
        {
            this.consultationFee = consultationFee;
        }

        public double CalculateBill()
        {
            return consultationFee;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Out Patient | ID: " + id);
            Console.WriteLine("Name: "+name);
            Console.WriteLine(doctor.GetDoctorInfo());
            Console.WriteLine("Total Bill: " + CalculateBill());
        }

    }
}
