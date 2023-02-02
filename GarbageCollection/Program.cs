using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollection
{
    class Mainclass
    {
        static void Main()
        {
            using(Employee e1 =new Employee(1))
            {
                e1.Salary = 10000;
                e1.WorkStatus();
                e1.IncrementSalary(2000);
            }
            using (Employee e2 = new Employee(2))
            {
                e2.Salary = 15000;
                e2.WorkStatus();
                e2.IncrementSalary(3000);
            }
            //e1.Dispose();
            Console.WriteLine("-----------------");
            //e1.Salary=100;
        }
    }

    
    
}
