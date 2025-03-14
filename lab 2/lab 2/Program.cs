using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            ISubscriptionFactory webPurchase = new WebSite();
            ISubscriptionFactory appPurchase = new MobileApp();
            ISubscriptionFactory callPurchase = new ManagerCall();

            SubscriptionProcessor.ProcessSubscription(webPurchase, 2);
            SubscriptionProcessor.ProcessSubscription(appPurchase, 3);
            SubscriptionProcessor.ProcessSubscription(callPurchase, 1);
        }
    }
}