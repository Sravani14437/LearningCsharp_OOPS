using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Ref
{
    class Mainclass
    {
        static void M(ref int x,out int y)
        {
            x = 100;
            y = 200;
        }
        static void Main()
        {
            int i = 10, j;
            M(ref i, out j);
            Console.WriteLine(i);
            Console.WriteLine(j);
        }
    }
}
