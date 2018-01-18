namespace VendingMachine
{
    public class CreditCard : Payment
    {
        public override double change(int paid, double price)
        {
            return paid-price;
        }
    }
}