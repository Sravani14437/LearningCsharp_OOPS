using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
public delegate void PrintDelegate();

namespace Delegate
{

        class Printer
        {
            public static void Print(PrintDelegate d)
            {
                    d();
            }
        }
    




}
