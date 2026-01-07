using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.EmployeeEx
{
    internal interface IEmployee
    {
        // Interface to provide security
        IEmployeeDetails AddEmployee();
        void GetEmployeeName(IEmployeeDetails employee,int i);
        void CheckAttendance(IEmployeeDetails employee);
        void GetDetails(IEmployeeDetails employee);
    }
}
