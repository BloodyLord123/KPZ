using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Warehouse
    {
        private Dictionary<string, Product> products = new Dictionary<string, Product>();
        private List<string> transactionLog = new List<string>();

        public void AddProduct(Product product, int quantity)
        {
            if (products.ContainsKey(product.Name))
            {
                products[product.Name].Quantity += quantity;
            }
            else
            {
                product.Quantity = quantity;
                products[product.Name] = product;
            }
            transactionLog.Add($"{DateTime.Now}: Отримано {product.Name} у кількості {quantity}");
        }

        public void RemoveProduct(string productName, int quantity)
        {
            if (products.ContainsKey(productName) && products[productName].Quantity >= quantity)
            {
                products[productName].Quantity -= quantity;
                transactionLog.Add($"{DateTime.Now}: Видалено {quantity} шт. {productName}");
                if (products[productName].Quantity == 0)
                {
                    products.Remove(productName);
                    transactionLog.Add($"{DateTime.Now}: Товар {productName} повністю видалено зі складу.");
                }
            }
            else
            {
                transactionLog.Add($"{DateTime.Now}: Не вдалося видалити товар {productName}. Недостатньо кількості або товар не знайдений.");
            }
        }


        public void DisplayProducts()
        {
            foreach (var product in products.Values)
            {
                Console.WriteLine($"{product.Name} - {product.Quantity} шт, {product.Price.WholePart}.{product.Price.Cents:D2} {product.Price.Currency}");
            }
        }

        public List<string> GetTransactionLog()
        {
            return transactionLog;
        }
    }
}