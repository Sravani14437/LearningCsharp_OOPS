using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateRealScenario
{
    public class UserProfile
    {
        public String Name;
        public int Age;
        public double Salary;
        public double Experience;
        public UserProfile(string name,int age,double sal,double ex)
        {
            this.Name = name;
            this.Age = age;
            this.Salary = sal;
            this.Experience = ex;
        }
        public static int CompareByName(object objA,object objB)
        {
            if(objA is UserProfile && objB is UserProfile)
            {
                UserProfile lu = (UserProfile)objA;
                UserProfile ru = (UserProfile)objB;
                return lu.Name.CompareTo(ru.Name);
            }
            return 0;
        }

    }
    
}
