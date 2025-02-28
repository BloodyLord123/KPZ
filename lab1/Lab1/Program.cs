using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main()
        {
            System.Globalization.CultureInfo customCulture =
            (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Money priceUSD = new Money(10, 50, "USD", 1.0m);
            Money priceEUR = new Money(9, 20, "EUR", 1.1m);
            Product product1 = new Product("Laptop", priceUSD, 5);
            Product product2 = new Product("Smartphone", new Money(5, 75, "USD", 1.0m), 1);
            Warehouse warehouse = new Warehouse();
            Reporting reporting = new Reporting(warehouse);

            warehouse.AddProduct(product1, 5);
            warehouse.AddProduct(product2, 1);

            reporting.GenerateInventoryReport();
            warehouse.RemoveProduct(product2.Name,1);
            reporting.GenerateTransactionReport();

            var convertedMoney = priceUSD.ConvertTo(priceEUR);
            Console.WriteLine($"\nКонвертовані гроші: {convertedMoney.WholePart}.{convertedMoney.Cents:D2} {convertedMoney.Currency}");
            product1.ReducePrice(2, 30);
            Console.WriteLine("\nПісля зменшення ціни:\n");
            reporting.GenerateInventoryReport();
            convertedMoney = product1.Price.ConvertTo(priceEUR);
            Console.WriteLine($"\nКонвертовані гроші після зміни ціни: {convertedMoney.WholePart}.{convertedMoney.Cents:D2} {convertedMoney.Currency}");
        }
    }
}