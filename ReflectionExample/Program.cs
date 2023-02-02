using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection

namespace ReflectionExample
{
    class Mainclass
    {
        static void Main()
        {
            int i = 10;
            Console.WriteLine(AppDomain.CurrentDomain);
            Console.WriteLine(i.GetType());
            Assembly a = Assembly.LoadFile("Here inserted selected path");
            Console.WriteLine(a.FullName);
            Console.WriteLine(a.GetName());
            Type[] types = a.GetTypes();
            foreach(Type t in types)
            {
                Console.WriteLine(t.FullName);
                MethodInfo[] methods = t.GetMethods();
                foreach(MethodInfo m in methods)
                {
                    Console.WriteLine(m.ReturnType);
                    Console.WriteLine(m.ReturnParameter);
                    ParameterInfo[] parameters = m.GetParameters();
                    foreach(ParameterInfo parameter in parameters)
                    {
                        Console.WriteLine(parameter.Name);
                        Console.WriteLine(parameter.ParameterType);
                        Console.WriteLine(parameter.GetType());
                        Console.WriteLine("-------------------------------");


                    }
                    Console.WriteLine("-------------------------");

                }
                Console.WriteLine("***************************");
            }

         


        }
    }
}
    
