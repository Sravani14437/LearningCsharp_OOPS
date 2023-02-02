using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableRevision
{
    class Mainclass
    {
        static void Main()
        {
            int x = 30, y = 20;
            Console.WriteLine(x.CompareTo(y));
            Employee emp1 = new Employee(1500);
            Employee emp2 = new Employee(1200);
            Console.WriteLine(emp1.CompareTo(emp2));
            Student[] yourArray = new Student[5];
            yourArray[0] = new Student(50);
            yourArray[1] = new Student(10);
            yourArray[2] = new Student(40);
            yourArray[3] = new Student(20);
            yourArray[4] = new Student(30);
            Array.Reverse(yourArray);
            Utilities.Sort(yourArray);
            foreach(Student s in yourArray)
            {
                Console.WriteLine(s.Marks + " ");
            }
            Console.WriteLine();
            int[] intArray = { 50, 10, 40, 30, 20 };
            Array.Reverse(intArray);
            Utilities.Sort(intArray);
            foreach(int i in intArray)
            {
                Console.WriteLine(i + " ");
            }


        }
    }
}
