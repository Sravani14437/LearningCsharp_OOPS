using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace OptionalAndNamedParameters
{
    class Mainclass
    {
        public static void M(string name,bool b =false,ArrayList mylist = null)
        {
            Console.WriteLine(name + "");
            Console.WriteLine(b);
        }
        static void Main(bool v)
        {
            M("Sravani");
            M("Sravani", true);
            M("Sravani", true, new ArrayList());
            M("Sravani", mylist: new ArrayList());
            M("Sravani", mylist: new ArrayList());

        }
    }
}
