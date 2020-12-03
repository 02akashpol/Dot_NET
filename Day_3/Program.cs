using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi2Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Manager");
            Manager m1 = new Manager("Akash", 11, 17000000, "Mgr");
            Console.WriteLine(m1.EmpName + "   " + m1.Basic);
            Console.WriteLine("Net sal : " + m1.calNetSalary());


            Console.WriteLine("=========================================");
            Console.WriteLine("GeneralManager");
            GeneralManager g1 = new GeneralManager("Avinash", 12, 16000000, "GMgr", "GOLD");
            Console.WriteLine(g1.EmpName + "   " + g1.Basic);
            Console.WriteLine("Net sal : " + g1.calNetSalary());

            Console.WriteLine("=========================================");
            Console.WriteLine("CEO");
            CEO c1 = new CEO("Akash", 13, 20000000);
            Console.WriteLine(c1.EmpName + "   " + c1.Basic);
            Console.WriteLine("Net sal : " + c1.calNetSalary());
            Console.ReadLine();
        }
    }

    public abstract class Employee
    {
        private static int empNoFlag;
        private int empNo;
        private String empName;
        private short deptNo;
        protected decimal basic;

        public Employee(String empName = "DemoName", short deptNo = 02, decimal basic = 23569)
        {
            empNo = ++empNoFlag;
            this.empName = empName;
            this.deptNo = deptNo;
            this.basic = basic;
        }

        public int EmpNo
        {
            get
            {
                return empNo;
            }
        }

        public String EmpName
        {
            set
            {
                if(value != "")
                {
                    empName = value;
                }
            }
            get
            {
                return empName;
            }
        }

        public short DeptNo
        {
            set
            {
                if (deptNo > 0)
                    deptNo = value;
                else
                    Console.WriteLine("Invalid dept number!");
            }
            get
            {
                return deptNo;
            }
        } 

        public abstract decimal Basic
        {
            set;
            get;
        }

        public abstract decimal calNetSalary();
    }

    public class Manager : Employee
    {
        private String designation;

        public Manager(String empName = "DemoName", short deptNo = 02, decimal basic = 23569, String designation = "Mgr") : base(empName, deptNo, basic)
        {
            this.designation = designation;
        }

        public String Designation
        {
            set
            {
                if (value != "")
                    designation = value;
                else
                    Console.WriteLine("Providing designation is must.");
            }
            get { return designation; }
        }

        public override decimal Basic
        {
            set 
            {
                if (basic != 0)
                    basic = value;
                else
                    Console.WriteLine("Basic should have some value.");
            }
            get { return basic; }
        }

        public override decimal calNetSalary()
        {
            decimal netSalary = basic - 5000;
            return netSalary;
        }
    }

    public class GeneralManager : Manager
    {
        private String perks;

        public GeneralManager(String empName = "DemoName", short deptNo = 02, decimal basic = 23569, String designation = "GMgr", String perks = "None") : base(empName, deptNo, basic, designation)
        {
            this.perks = perks;
        }

        public override decimal Basic
        {
            set
            {
                if (basic != 0)
                    basic = value;
                else
                    Console.WriteLine("Basic should have some value.");
            }
            get { return basic; }
        }

        public override decimal calNetSalary()
        {
            decimal netSalary = basic - 5000;
            return netSalary;
        }

    }

    public class CEO : Employee
    {
        public CEO(String empName = "DemoName", short deptNo = 02, decimal basic = 23569) : base(empName, deptNo, basic)
        {

        }

        public override decimal Basic
        {
            set
            {
                if (basic != 0)
                    basic = value;
                else
                    Console.WriteLine("Basic should have some value.");
            }
            get { return basic; }
        }

        public sealed override decimal calNetSalary()
        {
            decimal netSalary = basic - 5000;
            return netSalary;
        }
    }


}
