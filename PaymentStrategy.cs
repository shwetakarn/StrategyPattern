namespace StrategyApp
{
    public class PaymentStrategy 
    {
        IBillingStrategy _billingStrategy;
        public void  SetPaymentStrategy(IBillingStrategy strategy)
        {
            _billingStrategy=strategy;
        }

        public void Pay( double amount)
        {
            _billingStrategy.Pay(amount);
        }
    }
}