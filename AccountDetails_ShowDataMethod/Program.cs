using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountDetails_ShowDataMethod
{
    
namespace TransactionExample
    {
        internal class Accounts
        {
            public int Account_No;
            public string CustomerName;
            public string AccountType;

            public string TransactionType;
            public double amount;
            public double balance = 1000;
            public void Show()
            {
                Console.WriteLine("Enter Account Number:");
                this.Account_No = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Customer Name:");
                this.CustomerName = Console.ReadLine();
                Console.WriteLine("Enter Account Type:");
                this.AccountType = Console.ReadLine();
                Console.WriteLine("Enter Transaction Type(d->deposit/w->withdrawal):");
                this.TransactionType = Console.ReadLine();
                Console.WriteLine("Enter Account :");
                this.amount = Convert.ToDouble(Console.ReadLine());
                if (TransactionType == "d")
                {
                    TransactionType = "Deposit";
                    balance = balance + amount;
                }
                else if (TransactionType == "w" && amount < balance)
                {
                    TransactionType = "Withdrawal";
                    balance = balance - amount;
                }
                else if (TransactionType == "w" && amount > balance)
                {
                    TransactionType = "Transaction is not possible";
                }
                Console.WriteLine($"Account_Number:{Account_No}/nCustomer_Name:{CustomerName}/nAccount_Type:{AccountType}/nTransaction_Type:{TransactionType}/nAmount:{amount}/nRemainingBalance:{balance}");
            }
            public static void Main()
            {
                Accounts obj = new Accounts();
                obj.Show();
            }
        }
    }






}
