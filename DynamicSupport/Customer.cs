using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSupport
{
   public class Customer
    {
        string customerName;
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }

        }
        int customerId;
        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
        public Customer( int cid,string cname)
        {
            this.customerName = cname;
            this.customerId = cid;
        }
        public Customer()
        {

        }
        public string SayHello(string name)
        {
            return "Hello" + name;
        }
    }
}
