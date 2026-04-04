using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.HospitalPatientManagement
{
    internal abstract class Patient
    {
        protected int patientId;
        protected string name;
        protected int age;

        private string diagnosis;
        private string medicalHistory;

        public int PatientId
        {
            get { return patientId; }
            set { patientId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                    age = value;
            }
        }

        protected void SetMedicalData(string diagnosis, string history)
        {
            this.diagnosis = diagnosis;
            this.medicalHistory = history;
        }

        protected void ShowMedicalData()
        {
            Console.WriteLine($"Diagnosis: {diagnosis}");
            Console.WriteLine($"Medical History: {medicalHistory}");
        }

        public abstract double CalculateBill();

        public void GetPatientDetails()
        {
            Console.WriteLine($"ID: {PatientId}, Name: {Name}, Age: {Age}");
        }
    }
}
