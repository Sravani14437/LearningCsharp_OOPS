using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialStudent
{
    partial class Student
    {
        private static int id = 101;
        public readonly int Id;
        private string Name;
        private int Class;
        private int Marks;

        internal bool PrintMarkSheet()
        {
            throw new NotImplementedException();
        }
    }
}
