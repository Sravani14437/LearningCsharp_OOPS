using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentComparision
{
    class Mainclass
    {
        static int CompareMe(int i,int j)
        {
            if(i < j)
            {
                return -1;

            }
            else if(i > j)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        static void Main()
        {
            int i = 10, j = 20;
            Console.WriteLine(CompareMe(i, j));
        }
    }
    
           
}

