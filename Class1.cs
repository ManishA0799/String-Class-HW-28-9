using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Class_HW_28_9
{
     
        public class Customer
        {
            public int CustomerId { get; set; }
            public string CustomerLoan { get; set; }
        }

        public class Account
        {
            public int Aid { get; set; }
            public string Aname { get; set; }

            public List<Customer> Customers = new List<Customer>();
        }
    
}
