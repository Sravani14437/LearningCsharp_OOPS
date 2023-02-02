using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedExplanation
{
    class class1
    {
        protected virtual void M()
        {
            Console.WriteLine("class1::M");

        }

    }
    class class2 : class1
    {
        protected new void M()
        {
            Console.WriteLine("class2::M");
                
        }
        public void P()
        {
            class1 c1 = new class2();
            //c1.M()//not accessible

            Console.WriteLine("class2::P");
            base.M();
            this.M();
        }
    }
    class Mainclass
    {
        static void Main()
        {
            class1 c1 = new class1();
            //c1.M()//not accessible
            class2 c2 = new class2();
            //c2.M()//not accessible
            c1 = c2;
            c2.P();
        }
    }
}
