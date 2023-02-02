using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_Unboxing
{
    class Mainclass
    {
        static void Main()
        {
            int i = 10;
            object o = i;//boxing
            i++;
            
            Console.WriteLine(o);
            i = 20;o = 30;
            Console.WriteLine(o);
            Console.WriteLine(i);
            int j = (int)o;//unboxing
            Console.WriteLine(j);
            byte b = (byte)o;
            byte k = (byte)(int)o;
            Console.WriteLine(k);
        }
    }
}
