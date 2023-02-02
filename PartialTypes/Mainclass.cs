using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialTypes
{
    class Mainclass
    {
        static void Main()
        {
            UserProfile up = new UserProfile();
            up.Username = "sravani";
            up.Password = "12345";
            up.UID = 101;
            up.Print();
        }
    }
}
