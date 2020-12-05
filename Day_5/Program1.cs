using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] stdArr = new Student[5];

            for(int i=0; i<5; i++)
            {
                Console.WriteLine("Enter the details of {0} student.", i+1);

                Console.WriteLine("Enter the {0} student name : ", i+1);
                String stdName = Console.ReadLine();

                Console.WriteLine("Enter the {0} student roll number : ", i+1);
                int stdNo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the {0} student marks : ", i + 1);
                decimal stdmarks = Convert.ToInt32(Console.ReadLine());

                stdArr[i] = new Student(stdName, stdNo, stdmarks);
            }

            for(int i=0; i<5; i++)
            {
                Console.WriteLine("{0} Student Name : "+stdArr[i].StdName, i+1);
                Console.WriteLine("{0} Student Roll Name : " + stdArr[i].StdRollNo, i+1);
                Console.WriteLine("{0} Student Marks : " + stdArr[i].StdMarks, i+1);
                Console.WriteLine("--------------------------------------------");
            }

            Console.ReadLine();
        }
    }

    public struct Student
    {
        private String stdName;
        private int rollNo;
        private decimal marks;

        public Student(String stdName = "stdName", int rollNo = 0, decimal marks = 0)
        {
            this.stdName = stdName;
            this.rollNo = rollNo;
            this.marks = marks;
        }

        public String StdName
        {
            get { return stdName; }
        }

        public int StdRollNo
        {
            get { return rollNo; }
        }

        public decimal StdMarks
        {
            get { return marks; }
        }
    }
}
