using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableRevision
{
    class Employee : IComparable
    {
        private int _salary;
        public Employee(int salary)
        {
            this._salary = salary;
        }
        public int CompareTo(object e2)
        {
            return this._salary.CompareTo(((Employee)e2)._salary);
        }
        
    }
}
