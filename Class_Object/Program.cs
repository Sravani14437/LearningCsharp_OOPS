using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Class_Object
{
    internal class Employee
    {
        static int EmpNo = 101;
        private int _empId;
        private string _empName;
        private  decimal ?_empSalary;
        public Employee(string name)
        {
            this._empId = EmpNo++;
            this._empName = name;
        }
        public Employee( string empName, decimal empSalary)
        {
            this._empId = EmpNo++;
            this._empName = empName;
            this._empSalary = empSalary;
        }

         public string Print()
       
        {
            return string.Format("Emp Id:{0}\n\"Emp Name:{1}\nEmp Salary:{2}\n{3}",this._empId,this._empName,this._empSalary);        }
    }
}
