using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphism_abstraction.Employee_Management
{
    interface IDepartment
    {
        void AssignDepartment(string departmnetName);
        string GetDepartment();
    }
}
