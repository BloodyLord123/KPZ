using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Product
    {
        public string Name { get; private set; }
        public Money Price { get; private set; }
        public int Quantity { get; set; }

        public Product(string name, Money price, int quantity = 0)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public void ReducePrice(int whole, int cents)
        {
            int totalCents = (Price.WholePart * 100 + Price.Cents) - (whole * 100 + cents);
            if (totalCents < 0) totalCents = 0;
            Price = new Money(totalCents / 100, totalCents % 100, Price.Currency, Price.ExchangeRate);
        }
    }
}
