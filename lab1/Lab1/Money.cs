using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Money
    {
        public int WholePart { get; private set; }
        public int Cents { get; private set; }
        public string Currency { get; private set; }
        public decimal ExchangeRate { get; private set; }

        public Money(int whole, int cents, string currency, decimal exchangeRate)
        {
            Currency = currency;
            ExchangeRate = exchangeRate;
            SetMoney(whole, cents);
        }

        public void SetMoney(int whole, int cents)
        {
            if (whole < 0 || cents < 0)
                throw new ArgumentException("Значення не можуть бути від'ємними.");

            WholePart = whole + cents / 100;
            Cents = cents % 100;
        }

        public Money ConvertTo(Money targetCurrency)
        {
            int totalCents = (WholePart * 100 + Cents); 
            int baseCurrencyInCents = totalCents / (int)(ExchangeRate * 100); 
            int convertedAmountInCents = baseCurrencyInCents * (int)(targetCurrency.ExchangeRate * 100);
            int newWhole = convertedAmountInCents / 100;
            int newCents = convertedAmountInCents % 100;
            return new Money(newWhole, newCents, targetCurrency.Currency, targetCurrency.ExchangeRate);
        }
        public void Display()
        {
            Console.WriteLine($"{WholePart}.{Cents:D2} {Currency}");
        }
    }
}
