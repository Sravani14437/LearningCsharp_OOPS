using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingExample
{
    class Mainclass
    {
        static void Main()
        {
            int i = 10;
            object o = i;//boxing
            i++;
            Console.WriteLine(i);
            Console.WriteLine(o);
            ValueType v = i;//boxing
            Console.WriteLine(v);
        }
    }
}
