using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public static class SubscriptionProcessor
    {
        public static void ProcessSubscription(ISubscriptionFactory factory, int renewalMonths)
        {
            Console.WriteLine($"\nСтворення підписки через {factory.GetType().Name}.");

            ISubscription subscription = factory.CreateSubscription();
            subscription.ShowDetails();

            double totalCost = subscription.MonthlyFee * subscription.CurrentPeriod;
            Console.WriteLine($"Загальна вартість: {totalCost:F2}");

            subscription.RenewSubscription(renewalMonths);
            Console.WriteLine($"Підписка поновлена на {renewalMonths} місяць(ів). Новий період: {subscription.CurrentPeriod} місяців.");
            subscription.ShowDetails();
        }
    }
}
