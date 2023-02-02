using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace partial_Types
{
    
        partial class Student
        {

            public Student(string name, int cclass, int marks)
            {
                this.Name = name;
                this.Class = cclass;
                this.Marks = marks;
                this.Id = id++;
            }
        }
    }



