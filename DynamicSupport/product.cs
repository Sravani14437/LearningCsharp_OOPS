using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicSupport
{
    class Product
    {
        string productName;
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        int productId;
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        public Product(int pid,string pname)
        {
            this.productId = pid;
            this.productName = pname;
        }
        public Product()
        {
        }
            public string SayHello(string name)
            {
                return "Hello" + name;

            }
        
    }
}
