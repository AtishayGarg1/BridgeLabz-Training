using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.studentmanagement
{
    internal class StudentRecordManagement
    {
        StudentNode head;

        public StudentRecordManagement()
        {
            head = null;
        }

        public int CountNode()
        {
            int count = 0;
            StudentNode current = head;
            while (current != null)
            {
                count++;
                current = current.next;
            }
            return count;
        }


        public void AddAtBeginning(string  studentName, int studentId, int studentAge, string studentGrade)
        {
            StudentNode newNode = new StudentNode(studentName, studentId, studentAge, studentGrade);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }

        public void AddAtEnd(string studentName, int studentId, int studentAge, string studentGrade)
        {
            StudentNode newNode = new StudentNode(studentName, studentId, studentAge, studentGrade);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                StudentNode curr = head;
                while(curr.next != null)
                {
                    curr = curr.next;
                }
                curr.next = newNode;
            }
        }

        public void AddAtMiddle(string studentName, int studentId, int studentAge, string studentGrade, int position)
        {
            StudentNode newNode = new StudentNode(studentName, studentId, studentAge, studentGrade);
            int count = 1;
            if (head == null)
            {
                head = newNode;
                return;
            }
            if(position > CountNode())
            {
                Console.WriteLine("Invalid Position");
                return;
            }

            StudentNode curr = head;
            while (curr.next != null)
            {
                count++;
                if(count == position)
                {
                    break;
                }
                curr = curr.next;
            }
            newNode.next = curr.next;
            curr.next = newNode;
        }

        public void DeleteARecord(int StudentId)
        {
            StudentNode curr = head;
            if (head.StudentId == StudentId)
            {
                head = head.next;
                return;
            }
            while (curr.next != null)
            {
                if(curr.next.StudentId == StudentId )
                {
                    curr.next = curr.next.next;
                    break;
                }
                curr = curr.next;
            }
        }

        public void SearchStudent(int StudentId)
        {
            if(head == null)
            {
                return;
            }
            StudentNode curr = head;
            while(curr != null)
            {
                if(curr.StudentId == StudentId)
                {
                    Console.WriteLine();
                    Console.WriteLine(curr.ToString());
                    break;
                }
                curr = curr.next;
            }
        }

        public void UpdateGrade(int StudentId,string StudentGrade)
        {
            if(head == null)
            {
                return;
            }
            StudentNode curr = head;
            while(curr != null)
            {
                if(curr.StudentId == StudentId)
                {
                    curr.StudentGrade = StudentGrade;
                }
                curr = curr.next;
            }
        }

        public void DisplayAllStudents()
        {
            if(head == null)
            {
                return;
            }
            StudentNode curr = head;
            while(curr != null)
            {
                Console.WriteLine();
                Console.WriteLine(curr.ToString());
                curr = curr.next;
            }
        }

    }
}
