using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    delegate int del(int i);//delegate definition
    class SimpleExample
    {
        static int SQUARE(int n)
        {
            return n * n;
        }
        public static void Call()
        {
            del myDelegate = SQUARE;// instantiating delegate and assigning named method
            int j = myDelegate(5);
            Console.WriteLine(j);
            del anotherDelegate = delegate (int n) //Anonymous method
            {
                return n * n;

            };
            j = anotherDelegate(10);
            Console.WriteLine(j);
            del lambda = x => x * x;
            j = lambda(15);
            Console.WriteLine(j);
        }
    }
}
