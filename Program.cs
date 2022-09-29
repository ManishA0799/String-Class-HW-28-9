using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Class_HW_28_9
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Account> accountList = new List<Account>()
            {
                new Account
                {
                    Aid=1,Aname="Saving",
                    Customers=
                    {
                    new Customer{CustomerId=1,CustomerLoan="Home Loan"},
                    new Customer{CustomerId=1,CustomerLoan="Car Loan"},
                    new Customer{CustomerId=2,CustomerLoan="Home Loan"},
                    }
                },
                new Account
                {
                      Aid=1,Aname="Current",
                    Customers=
                    {
                    new Customer{CustomerId=10,CustomerLoan="Gold Loan" },
                   
                    }
                },
            };

            foreach (Account a in accountList)
            {
                Console.WriteLine(a.Aname);
                foreach (Customer c in a.Customers )
                {
                    Console.WriteLine("\t"+c.CustomerId+ "\t"+ c.CustomerLoan);
                }
            }




            
        }
    }
}
