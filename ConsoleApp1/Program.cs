using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class class1
    {
        public const int x = 10;//const is implicit statoic .const cannot be changed once initialized and it must be initialized where its declared
        public readonly int y = 10;
        public class1()
        {
            this.y = 100; //readonly field can be changed inside constructor only

        }
        class Mainclass
        {
            static void Main()
            {
                class1 c1 = new class1();
                Console.WriteLine(class1.x);
                Console.WriteLine(c1.y);

            }


        }

    }
}