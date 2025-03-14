using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1;

namespace task1
{
    public class DomesticSubscription : ISubscription
    {
        public string Name => "Домашня підписка";
        public double MonthlyFee => 10.99;
        public int MinSubscriptionPeriod => 3;
        public int CurrentPeriod { get; set; } = 3;
        public List<string> Channels => new List<string> { "Новини", "Розваги", "Спорт" };
        public List<string> Features => new List<string> { "HD трансляція" };

        public void ShowDetails()
        {
            Console.WriteLine($"Підписка: {Name}");
            Console.WriteLine($"Щомісячна плата: {MonthlyFee}$");
            Console.WriteLine($"Мінімальний період: {MinSubscriptionPeriod} місяців");
            Console.WriteLine($"Поточний період: {CurrentPeriod} місяців");
            Console.WriteLine("Канали: " + string.Join(", ", Channels));
            Console.WriteLine("Можливості: " + string.Join(", ", Features));
            Console.WriteLine();
        }

        public void RenewSubscription(int months)
        {
            CurrentPeriod += months;
        }
    }
}
