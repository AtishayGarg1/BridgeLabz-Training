using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.HospitalPatientManagement
{
    internal interface IMedicalRecord
    {
        void AddRecord(string diagnosis, string medicalHistory);
        void ViewRecords();
    }
}
