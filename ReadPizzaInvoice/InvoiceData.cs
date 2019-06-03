using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadPizzaInvoice
{
    public class InvoiceData
    {
        /*
         * This is a simalar class to the InvoiceItem class from the Pizza Emporium
         * But, they are neither the same in structure or purpose
         */
         
        public int Id { get; set; }
        public DateTime SellDate { get; set; }
        public string BranchName { get; set; }
        public decimal TotalOrder { get; set; }

        public InvoiceData() { }


        public override string ToString()
        {
            return String.Format("Invoice {0} Sell Date {1:d} Branch Name {2} Total Order {3:C}", Id, SellDate, BranchName, TotalOrder);
        }
    }
}
