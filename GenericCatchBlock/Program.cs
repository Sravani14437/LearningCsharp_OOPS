﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCatchBlock
{
    class Mainclass
    {
        static void Main()
        {
            int i = 10, j = 0;
            try
            {
                Console.WriteLine(i / j);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Hello your second argument is zero");
                Console.WriteLine(ex.Message);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally  in main");
            }
            Console.WriteLine("------------------");
        }
    }
}
