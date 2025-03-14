using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public interface ISubscription
    {
        string Name { get; }
        double MonthlyFee { get; }
        int MinSubscriptionPeriod { get; }
        int CurrentPeriod { get; set; }
        List<string> Channels { get; }
        void ShowDetails();
        void RenewSubscription(int months);
    }
}
