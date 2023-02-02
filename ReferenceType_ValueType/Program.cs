using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceType_ValueType
{
    class class1
    {
        public int x;

    }
    struct student
    {
        public int y;

    }
    class Mainclass
    {
        static void Main()
        {
            class1 c1 = new class1();
            c1.x = 10;
            class1 c2 = new class1();
            c2.x = 20;
            c1 = c2;//reference copy
            c1.x = 30;
            Console.WriteLine(c1.x);
            Console.WriteLine(c2.x);
            Console.WriteLine("---------------------");
            student s1 = new student();
            student s2;
            s2.y = 20;
            s1.y = 10;
            s1 = s2;//value copy
            s1.y = 30;
            Console.WriteLine(s1.y);
            Console.WriteLine(s2.y);
            Console.WriteLine("------------------");
            int i = new int();//calling constructor of int32 to initializer i with default value  0
            Console.WriteLine(i);
        }
    }
}
