using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.studentmanagement
{
    internal class StudentNode
    {
        public string StudentName;
        public int StudentId;
        public int StudentAge;
        public string StudentGrade;
        public StudentNode next;

        public StudentNode(string studentName, int studentId, int studentAge, string studentGrade)
        {
            StudentName = studentName;
            StudentId = studentId;
            StudentAge = studentAge;
            StudentGrade = studentGrade;
            this.next = null;
        }

        public override string? ToString()
        {
            return "Student Name: " + StudentName + "\nStudent ID: " + StudentId + "\nStudent Age: " + StudentAge + "\nStudent Grade: " + StudentGrade;
        }
    }
}
