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
        private int EmployeeWorkHours;
        private string EmployeeType;
        private int EmployeeWorkingDays;
        public string EmployeeName1 { get => EmployeeName; set => EmployeeName = value; }
        public int EmployeeId1 { get => EmployeeId; set => EmployeeId = value; }
        public double EmployeeSalary1 { get => EmployeeSalary; set => EmployeeSalary = value; }
        public int EmployeeWorkHours1 { get => EmployeeWorkHours; set => EmployeeWorkHours = value; }
        public string EmployeeType1 { get => EmployeeType; set => EmployeeType = value; }
        public int EmployeeWorkingDays1 { get => EmployeeWorkingDays; set => EmployeeWorkingDays = value; }

        public override string ToString()
        {
            if(EmployeeType.Equals("Part Time"))
            {
                return "Name: " + EmployeeName + "\nID: " + EmployeeId + "\nEmployee Type: " + EmployeeType + "\nEmployee Salary: " + EmployeeSalary+"\nTotal Working Days: "+EmployeeWorkingDays+"\nTotal Working Hours: "+EmployeeWorkHours*EmployeeWorkingDays;
            }
            return "Name: "+EmployeeName+"\nID: "+ EmployeeId+"\nEmployee Type: "+EmployeeType+ "\nEmployee Salary: "+ EmployeeSalary;
        }
    }
}