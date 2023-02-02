using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHandling
{
     class Mainclass
    {
        static void StringOperation()
        {
            string s = "Sravani";
            Console.WriteLine("Original string is:"+s);
            string p = "Srinu";
            bool b = object.ReferenceEquals(s, p);
            Console.WriteLine(b);
            string q = s.Replace('i', 'p');
            Console.WriteLine("New string with replaced character:" + q);
            Console.WriteLine("-----------------------");
            string anotherName = "Sravan Kumar Teju";
            foreach(string part in anotherName.Split(' '))
            {
                Console.WriteLine(part);
            }


        }
        static void Main(string[] args)
        {
            {
                StringOperation();
            }
        }
    }
}
