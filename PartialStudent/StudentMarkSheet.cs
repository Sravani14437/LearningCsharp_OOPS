using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialStudent
{

    partial class StudentMarkSheet
    {
        private int Id;
        private object cClass;
        private object Marks;

        
        private int Name;

        public void PrintMarkSheet()
        {
            Console.WriteLine("Id :{0}\n Name :{1}\n Class:{2}\n Marks:{3}", this.Id, this.Name, this.cClass, this.Marks);
        }
    }
}
