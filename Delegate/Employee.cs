using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Employee
    {
        int empID;
        string empName;
        int basic, da, hra;
        public Employee(int id, string name, int basic, int da, int hra)
        {
            this.empID = id;
            this.empName = name;
            this.basic = basic;
            this.da = da;
            this.hra = hra;
        }
        private int salary
        {
            get
            {
                return basic + da + hra;
            }
        }
        public void SalarySlip()
        {
            Console.WriteLine("Employee Id: {0}", this.empID);
            Console.WriteLine("Employee Name: {0}", this.empName);
            Console.WriteLine("Salary: {0}", salary);
        }
        public void GenetareSalarySlip()
        {
            //PrintDelegate d = new PrintDelegate(Display);
            Printer.Print(SalarySlip);
        }
    }
}





