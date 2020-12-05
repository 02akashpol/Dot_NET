using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of employees : ");
            int size = Convert.ToInt32(Console.ReadLine());

            ArrayList arrLi = new ArrayList();

            for(int i=0; i<size; i++)
            {
                Console.WriteLine("Enter the id of {0} employee : ", i+1);
                int empId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the name of {0} employee : ", i+1);
                String empName = Console.ReadLine();

                Console.WriteLine("Enter the salary of {0} employee : ", i+1);
                decimal empSalary = Convert.ToInt32(Console.ReadLine());

                arrLi.Add(new Employee(empId, empName, empSalary));
            }

            //arrLi.Sort();
            Console.WriteLine("The details of all employee.");
            foreach(Employee trav in arrLi)
            {
                Console.Write(" Employee Id : "+trav.EmpNo);
                Console.Write(" Employee Name : " +trav.EmpName);
                Console.WriteLine(" Employee Salary : " +trav.EmpSalary);
                Console.WriteLine("------------------------------");
            }

            decimal salary = 0;

            foreach (Employee trav in arrLi)
            {
                if (salary < trav.EmpSalary)
                    salary = trav.EmpSalary;
            }

            foreach (Employee trav in arrLi)
            {
                if (trav.EmpSalary == salary)
                {
                    Console.WriteLine("The details of employee with highest salary.");
                    Console.Write(" Employee Id : " + trav.EmpNo);
                    Console.Write(" Employee Name : " + trav.EmpName);
                    Console.WriteLine(" Employee Salary : " + trav.EmpSalary);
                    Console.WriteLine("------------------------------");
                }
            }

            Console.WriteLine("Enter the emp id to get details of that employee.");
            int empId1 = Convert.ToInt32(Console.ReadLine());
            //int index = arrLi.IndexOf(empId1);

            Boolean flag = false;
            foreach(Employee trav in arrLi)
            {
                if(trav.EmpNo == empId1)
                {
                    flag = true;
                    Console.Write(" Employee Id : " + trav.EmpNo);
                    Console.Write(" Employee Name : " + trav.EmpName);
                    Console.WriteLine(" Employee Salary : " + trav.EmpSalary);
                    Console.WriteLine("------------------------------");
                }
            }
            if (flag == false)
                Console.WriteLine("The entered emp id is not present in our data.");

            /*
            foreach (Employee trav in arrLi)
            {
                if()

                Console.WriteLine(trav);
            } 
            */

            Console.ReadLine();
        }
    }

    public struct Employee
    {
        private int empNo;
        private String empName;
        private decimal empSalary;

        public Employee(int empNo, String empName, decimal empSalary)
        {
            this.empNo = empNo;
            this.empName = empName;
            this.empSalary = empSalary;
        }

        public int EmpNo
        {
            get { return empNo; }
        }

        public String EmpName
        {
            get { return empName; }
        }

        public decimal EmpSalary
        {
            get { return empSalary; }
        }

    }
}
