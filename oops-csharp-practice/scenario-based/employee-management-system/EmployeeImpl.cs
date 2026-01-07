using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.EmployeeEx
{
    internal class EmployeeImpl : IEmployeeDetails
    {
        // Encapsulated class 
        private string EmployeeName;
        private int EmployeeId;
        private double EmployeeSalary;
        public string EmployeeName1 { get => EmployeeName; set => EmployeeName = value; }
        public int EmployeeId1 { get => EmployeeId; set => EmployeeId = value; }
        public double EmployeeSalary1 { get => EmployeeSalary; set => EmployeeSalary = value; }

        public override string ToString()
        {
            return "Name: "+EmployeeName+"\nID"+ EmployeeId+ "\nEmployee Salary: "+ EmployeeSalary;
        }
    }
}