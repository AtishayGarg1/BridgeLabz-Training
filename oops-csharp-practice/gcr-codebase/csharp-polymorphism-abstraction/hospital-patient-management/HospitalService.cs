using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.HospitalPatientManagement
{
    internal class HospitalService
    {
        public static void ProcessPatients(Patient[] patients)
        {
            for (int i = 0; i < patients.Length; i++)
            {
                Patient patient = patients[i];

                patient.GetPatientDetails();
                Console.WriteLine($"Bill Amount: {patient.CalculateBill()}");

                if (patient is IMedicalRecord record)
                {
                    record.ViewRecords();
                }
            }
        }
    }
}
