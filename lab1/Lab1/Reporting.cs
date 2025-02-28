using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Reporting
    {
        private Warehouse warehouse;

        public Reporting(Warehouse warehouse)
        {
            this.warehouse = warehouse;
        }

        public void GenerateInventoryReport()
        {
            Console.WriteLine("Звіт по залишках на складі:");
            warehouse.DisplayProducts();
        }

        public void GenerateTransactionReport()
        {
            Console.WriteLine("\nЖурнал транзакцій:");
            foreach (var record in warehouse.GetTransactionLog())
            {
                Console.WriteLine(record);
            }
        }
    }

}
