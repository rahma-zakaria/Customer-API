using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Customer:BaseEntity
    {
        public String CustomerName { get; set; }
        public String PurchasesProduct { get; set; }
        public String PaymentType { get; set; }
    }
}
