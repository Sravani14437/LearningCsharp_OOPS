using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialStudent
{
    class Mainclass
    {
        public static void Main()
        {
            Student s1 = new Student("Sravani", 45, 67);
            Console.WriteLine(s1.PrintMarkSheet());
        }
    }
}
