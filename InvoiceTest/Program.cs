namespace InvoiceTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Part Number of product: ");
            string partNumber = Console.ReadLine();

            Console.Write("Enter the Part Description of product: ");
            string partDescription = Console.ReadLine();

            Console.Write("Enter quantity purchased: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter price per item: ");
            decimal pricePerItem = Convert.ToDecimal(Console.ReadLine());

            Invoice invoice = new Invoice(quantity, pricePerItem);

            invoice.PartNumber = partNumber;
            invoice.PartDescription = partDescription;


            Console.WriteLine(invoice.DisplayInvoice());
        }
    }
}