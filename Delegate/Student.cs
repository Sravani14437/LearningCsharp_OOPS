using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    



    class Student
    {
        int studID;
        string studName;
        public Student(int id, string name)
        {
            this.studID = id;
            this.studName = name;
        }
        public void Display()
        {
            Console.WriteLine("Student Id: {0}", this.studID);
            Console.WriteLine("Sudentt Name: {0}", this.studName);
        }
        public void DisplayDetails()
        {
            PrintDelegate d = new PrintDelegate(Display);



            Printer.Print(d);
        }
    }
}
