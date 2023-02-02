using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
        public class MainClass
        {
            public static void Main(string[] args)
            {
                Customer cust = new Customer(101, "Pranathi");
                Employee emp = new Employee(111, "Jyothi", 2000, 1000, 300);
                Student stud = new Student(2101, "Jyothi Pranathi");
                cust.Availservice();
                Console.WriteLine("---------------------------");
                emp.SalarySlip();
                Console.WriteLine("---------------------------");
                stud.DisplayDetails();
                Console.ReadKey();
                //Console.WriteLine ("Hello Mono World");
            }
        }
    
}



