namespace VendingMachine
{
    public class Banknote : Payment
    {
        public override double change(int paid, double price)
        {
            return paid-price;
        }
    }
}