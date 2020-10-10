using System;
namespace StrategyPattern
{
    public class CashConcretStrategy : IBillingStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Customer Pay's Rs {amount} using Cash.");
        }
    }
}