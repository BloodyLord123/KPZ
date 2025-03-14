using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1;

namespace task1
{
    public class ManagerCall : ISubscriptionFactory
    {
        public ISubscription CreateSubscription()
        {
            Console.WriteLine("Оформлення підписки через дзвінок менеджеру...");
            return new EducationalSubscription();
        }
    }
}
