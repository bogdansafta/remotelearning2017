namespace VendingMachine
{
    public class CreditCardPayment : Payment
    {
        public override double AmountPaid { get; set; }

        public override double GetChange(double amountPaid, double price)
        {
            return 0;
        }
    }
}