using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1;

namespace task1
{
    public class PremiumSubscription : ISubscription
    {
        public string Name => "Преміум підписка";
        public double MonthlyFee => 19.99;
        public int MinSubscriptionPeriod => 1;
        public int CurrentPeriod { get; set; } = 1;
        public List<string> Channels => new List<string> { "Всі канали", "Ексклюзивний спорт", "Преміум фільми" };
        public List<string> Features => new List<string> { "4K трансляція", "Підтримка кількох пристроїв" };

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
