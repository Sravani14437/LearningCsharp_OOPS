using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableRevision
{
    public struct Student: IComparable
    {
        private int _marks;
        public Student(int marks)
        {
            this._marks = marks;
        }
        public int CompareTo(object s)
        {
            return this._marks.CompareTo(((Student)s)._marks);

        }
        public int Marks
        {
            get
            {
                return this._marks;

            }
        }
    }
    
    
}
