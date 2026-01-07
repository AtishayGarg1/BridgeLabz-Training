using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.EmployeeEx
{
    interface IEmployeeDetails
    {
        // Interface to provide security
        string EmployeeName1 { get; set; }
        int EmployeeId1 { get; set; }
        double EmployeeSalary1 { get; set; }
        int EmployeeWorkHours1 {  get; set; }
        string EmployeeType1 {  get; set; }

        string ToString();
    }
}
