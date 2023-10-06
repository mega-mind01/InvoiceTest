using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceTest
{
    internal class Invoice
    {
        private string partNumber;
        private string partDescription;
        private int quantity;
        private decimal pricePerItem;

        public string PartNumber { get; set; }
        public string PartDescription { get; set; }
        private int Quantity 
        {
           set
            {
                if (value > 0)
                {
                    quantity = value;
                }
            }
            get
            {
                return quantity;
            }
        }
        private decimal PricePerItem
        {
            set
            {
                if (value > 0)
                {
                    pricePerItem = value;
                }
            }
            get
            {
                return pricePerItem;
            }
        }
        public Invoice(int quantity, decimal price)
        {
            PartNumber = string.Empty;
            PartDescription = string.Empty;
            Quantity = quantity;
            PricePerItem = price;
        }

        public decimal GetInvoiceAmount ()
        {
            decimal price = PricePerItem * Quantity;
            return price;
        }

        public string DisplayInvoice ()
        {
            return $"\nThe product: {PartNumber}\nProduct Description: {PartDescription}\nQuantity Purchased: {Quantity}\nThe Price: {GetInvoiceAmount()}";
        }
    }
}
