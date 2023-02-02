using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialTypes
{
    partial class UserProfile
    {
        
            public void Print()
            {
            Console.WriteLine("UserName={0}", this._username);
            Console.WriteLine("UserName={0}", this._password);
            Console.WriteLine("UserName={0}", this._uid);


        }
        
    }
}
