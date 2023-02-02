using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwapUsingIComparable_Interface
{
        class test<T> where T : IComparable<T>
        {
            public static bool CompareTo(object c, object d)
            {
                if (c.Equals(d))
                {
                    return true;
                }
                return false;
            }

            public static void Swap<T>(T a, T b)
            {
                bool p;
                object x = a;
                object y = b;
                p = CompareTo(x, y);
                if (p == true) { Console.WriteLine("Values of a and b are Equal"); }
                else
                {
                    T temp = a;
                    a = b;
                    b = temp;
                    Console.WriteLine("After Swap i={0},j={1}", a, b);
                }
            }
        }
        // private void Sort()
        // {
        //
        //  T item1;
        // T item2;
        // if(item1.CompareTo(item2) < 0)
        // {
        //bla bla
        // }
        //}
        public class MyMainClass
        {
            public static void Main()
            {
                int i = 10;
                int j = 20;
                test<int>.Swap<int>(i, j);
            }
        }
    }




