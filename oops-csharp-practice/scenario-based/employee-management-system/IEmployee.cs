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
        Employee AddEmployee();
        void GetEmployeeName(Employee employee,int i);
        void CheckAttendance(Employee employee);
        void GetDetails(Employee employee);
        void CalculateWage(Employee employee);
        void EmployeeType(Employee employee);
        void CalculateMonthAttendance(Employee employee);
        bool CheckAttendance3(Employee employee);
    }
}
