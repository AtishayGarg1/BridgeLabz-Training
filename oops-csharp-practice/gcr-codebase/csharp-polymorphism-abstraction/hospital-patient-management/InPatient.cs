using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.HospitalPatientManagement
{
    internal class InPatient : Patient, IMedicalRecord
    {
        public int NumberOfDays { get; set; }
        public double DailyCharge { get; set; }

        public override double CalculateBill()
        {
            return NumberOfDays * DailyCharge;
        }

        public void AddRecord(string diagnosis, string medicalHistory)
        {
            SetMedicalData(diagnosis, medicalHistory);
        }

        public void ViewRecords()
        {
            ShowMedicalData();
        }
    }
}
