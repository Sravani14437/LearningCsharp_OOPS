using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethodExample
{
    delegate void PrintDelegate();
    class Mainclass
    {
        public static void M()
        {
            Console.WriteLine("Hello");
        }
        static void Main()
        {
            PrintDelegate p = M;
            p += delegate ()
            {
                Console.WriteLine("How are you");
            };
            p();
        }
    }
}
