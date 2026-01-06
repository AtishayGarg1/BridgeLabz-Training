using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.hospitalmanagement
{
    internal class Doctor
    {
        protected string doctorName;
        protected string specialization;

        public Doctor(string doctorName, string specialization)
        {
            this.doctorName = doctorName;
            this.specialization = specialization;
        }

        public string GetDoctorInfo()
        {
            return "\nDoctor Name: " + doctorName + "\nSpecialization: " + specialization;
        }
    }
}
