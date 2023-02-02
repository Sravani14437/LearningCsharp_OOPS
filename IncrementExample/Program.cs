using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementExample
{
    internal class MainClass
    {
        int x;
        static int y;
        public MainClass()
        {
            ++x;
            ++y;

        }
        static void Main()
        {
            MainClass m1 = new MainClass();
            MainClass m2 = new MainClass();
            MainClass m3 = new MainClass();
            Console.WriteLine(m3.x);
            Console.WriteLine(MainClass.y);




        }
    }
}
