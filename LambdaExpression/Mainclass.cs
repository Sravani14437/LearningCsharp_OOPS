using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    delegate int MyDelegate(int x);
    class Mainclass
    {
        static int Add(int x)
        {
            return x + x;
        }
        static void Main()
        {
            MyDelegate d = Add;
            d += delegate (int x)
            {
                return x - x;
            };
            d += (x) => x * x;
            d += (x) => x / x;
            Console.WriteLine(d(10));
            foreach(MyDelegate del in d.GetInvocationList())
            {
                Console.WriteLine(del.Invoke(10));
            }
        }
    }
    
}
