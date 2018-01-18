namespace VendingMachine
{
    public class CoinPayment : Payment
    {
        public override double AmountPaid { get; set; }

        public override double GetChange(double amountPaid, double price)
        {
            return amountPaid - price;
        }
    }
}