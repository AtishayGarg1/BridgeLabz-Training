using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.sorting
{
    internal class StudentMarks
    {
        public void BubbleSort(int[] studentMarks)
        {
            for(int i = 0; i < studentMarks.Length - 1; i++)
            {
                for(int j = 0; j <  studentMarks.Length - i - 1; j++)
                {
                    if (studentMarks[j] > studentMarks[j + 1])
                    {
                        int temp = studentMarks[j];
                        studentMarks[j] = studentMarks[j + 1];
                        studentMarks[j + 1] = temp;
                    }
                }
            }
            DisplayAll(studentMarks);
        }
        public void DisplayAll(int[] studentMarks)
        {
            for( int i = 0; i < studentMarks.Length - 1; i++)
            {
                Console.Write(studentMarks[i]+", ");
            }
            Console.Write(studentMarks[studentMarks.Length-1]);
        }

        static void Main(string[] args)
        {
            StudentMarks studentMarks = new StudentMarks();
            int[] studentMarksArray = { 98, 67, 87, 99, 44, 64, 54, 87, 67, 76, 100 };
            Console.WriteLine("Before Sorting");
            studentMarks.DisplayAll(studentMarksArray);
            Console.WriteLine("After Sorting");
            studentMarks.BubbleSort(studentMarksArray);
        }

    }
}
