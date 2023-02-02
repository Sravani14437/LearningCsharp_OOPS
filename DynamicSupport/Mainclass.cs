using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSupport
{
    class Mainclass
    {
        static dynamic x;//dynamic can be declared in class member also
        public static object GetCustomer()
        {
            return new Customer();
        }
        public static object GetProduct()
        {
            return new Product();
        }
        static void Main()
        {
            Mainclass.x = 100;
            Console.WriteLine(Mainclass.x);
            dynamic obj; obj = GetCustomer();
            obj.CustomerId = 101;
            obj.CustomerName= "Sravani";
            Console.WriteLine(obj.CustomerId + " ");
            Console.WriteLine(obj.SayHello("Sravani"));
            Console.WriteLine(obj.GetType());
            obj = GetProduct();
            obj.ProductId = 101;
            obj.ProductName = "Bolt";
            Console.WriteLine(obj.ProductId + " ");
            Console.WriteLine(obj.ProductName);
            Console.WriteLine(obj.SayHello("Sravan"));
            Console.WriteLine(obj.GetType());
            Console.WriteLine("------------------------------");
            Customer cust = new Customer();
            dynamic dycust
                = cust;
            dycust.CustomerId = 1001;
            Console.WriteLine(cust.CustomerId);
            Customer newRef
                = dycust;
            newRef.CustomerId = 102;
            Console.WriteLine(dycust.CustomerId);
            cust.CustomerName = "Sravani";
            Console.WriteLine(newRef.CustomerName);
            Console.WriteLine("--------------------------");
            int id = cust.CustomerId;//return dynamic so conversion occurs
            dynamic name = cust.CustomerName;//no conversion occurs
            object o = cust.CustomerId;//conversion occurs
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(o);


        }

    }
}
