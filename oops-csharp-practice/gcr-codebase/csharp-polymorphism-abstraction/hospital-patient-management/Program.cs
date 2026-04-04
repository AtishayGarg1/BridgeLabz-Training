using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.HospitalPatientManagement
{
    internal class Program
    {
        static void Main()
        {
            InPatient inpatient = new InPatient();
            inpatient.PatientId = 1;
            inpatient.Name = "Rahul";
            inpatient.Age = 45;
            inpatient.NumberOfDays = 5;
            inpatient.DailyCharge = 3000;
            inpatient.AddRecord("Pneumonia", "Admitted for respiratory care");

            OutPatient outpatient = new OutPatient();
            outpatient.PatientId = 2;
            outpatient.Name = "Anita";
            outpatient.Age = 30;
            outpatient.ConsultationFee = 800;
            outpatient.AddRecord("Fever", "Routine checkup");

            Patient[] patients = new Patient[2];
            patients[0] = inpatient;
            patients[1] = outpatient;

            HospitalService.ProcessPatients(patients);
        }
    }
}
