using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.HospitalPatientManagement
{
    internal class OutPatient : Patient, IMedicalRecord
    {
        public double ConsultationFee { get; set; }

        public override double CalculateBill()
        {
            return ConsultationFee;
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
