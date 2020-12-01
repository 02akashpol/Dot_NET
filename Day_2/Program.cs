using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        private static int empNo;
        private String empName;
        private decimal basic;
        private int deptNo;
 
        public Employee(String empName, decimal basic, int deptNo)
        {
            this.empName = empName;
            this.basic = basic;
            this.deptNo = deptNo;
            empNo++;
        }

        public Employee(String empName, decimal basic)
        {
            this.empName = empName;
            this.basic = basic;
            empNo++;
        }

        public Employee(String empName)
        {
            this.empName = empName;
            empNo++;
        }

        public Employee()
        {

            empNo++;
        }

        void display()
        {
            Console.WriteLine("Employee No : "+empNo+ " Employee Name : " + empName + " Employee Basic Salary : " + basic + " Employee Dept No : " + deptNo);
        }

        static void Main(string[] args)
        {
            Employee obj1 = new Employee("Amol", 123465, 10);
            Employee obj2 = new Employee("Amol", 123465);
            Employee obj3 = new Employee("Amol");
            Employee obj4 = new Employee();

            obj1.display();
            Console.ReadLine();
            obj2.display(); 
            Console.ReadLine();
            obj3.display();
            Console.ReadLine();
            obj4.display();
            Console.ReadLine();
        }
    }
}
