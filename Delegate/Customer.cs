using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate
{
    
class Customer
    {
        int cusID;
        string cusName;
        public Customer(int id, string name)
        {
            this.cusID = id;
            this.cusName = name;
        }
        public void Display()
        {
            Console.WriteLine("Customer Id: {0}", this.cusID);
            Console.WriteLine("Customer  Name: {0}", this.cusName);
        }
        public void Availservice()
        {
            PrintDelegate d = new PrintDelegate(Display);
            Printer.Print(d);
        }

    }
}




