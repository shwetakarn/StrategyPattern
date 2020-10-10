 using System;
namespace StrategyPattern
{
 public class DebtConcretStrategy : IBillingStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Customer Pay's Rs {amount} using Debt Card.");
        }
    }
}