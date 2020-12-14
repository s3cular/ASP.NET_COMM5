using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_COMM5.Models
{
    public class Customer
    {
        public int customerId { get; set; }

        public string name { get; set; }

        public DateTime dateOfPurchase { get; set; }

        public string product { get; set; }

        public int quantity { get; set; }

        public decimal price { get; set; }

        
    }
}
