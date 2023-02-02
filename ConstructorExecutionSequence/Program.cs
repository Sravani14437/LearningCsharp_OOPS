using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExecutionSequence
{
    public class MYBaseClass
    {
        public MYBaseClass()
        {
            Console.WriteLine("Inside base class with 0 parameter");
        }
        public MYBaseClass(int i)
        {
            Console.WriteLine("Inside base class with 1 paramenter:{0}", i);
        }
    }
    public class MyDerivedClass : MYBaseClass
    {
        public MyDerivedClass()
        {
            Console.WriteLine("Inside Derived class with 0 parameter");
        }
        public MyDerivedClass(int i): this(i,9) 
        {
                Console.WriteLine("Inside derived class with 1 parameter :{0}",i); 


        }
        public MyDerivedClass(int i,int j) : base(j)
        {
            Console.WriteLine("Inside derived class with 2 parameter :{0},{1}", i,j);

        }
    }
    class Mainclass
    {
        static void Main()
        {
            MyDerivedClass myobj = new MyDerivedClass();
            Console.WriteLine("---------------------");
            MyDerivedClass myobj1 = new MyDerivedClass(4);
            Console.WriteLine("======================");
            MyDerivedClass myobj2 = new MyDerivedClass(4, 8);
        }
    }

            
        
    
}
