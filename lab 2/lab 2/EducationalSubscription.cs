using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1;

namespace task1
{
    public class EducationalSubscription : ISubscription
    {
        public string Name => "Навчальна підписка";
        public double MonthlyFee => 7.99;
        public int MinSubscriptionPeriod => 6;
        public int CurrentPeriod { get; set; } = 6;
        public List<string> Channels => new List<string> { "Discovery", "National Geographic", "History Channel" };
        public List<string> Features => new List<string> { "Без реклами", "Офлайн-доступ" };

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
