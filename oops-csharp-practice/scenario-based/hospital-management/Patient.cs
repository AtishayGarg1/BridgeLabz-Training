using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.hospitalmanagement
{
    internal abstract class Patient
    {
        protected string name;
        protected int id;
        protected Doctor doctor;

        public Patient(string name, int id, Doctor doctor)
        {

            this.id = id;
            this.name = name;
            this.doctor = doctor;
        }

        public abstract void DisplayInfo();

    }
}
