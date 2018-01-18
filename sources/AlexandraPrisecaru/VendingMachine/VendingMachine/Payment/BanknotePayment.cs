namespace VendingMachine
{
    public class BanknotePayment : Payment
    {
        public override double AmountPaid { get; set; }

        public override double GetChange(double amountPaid, double price)
        {
            return amountPaid - price;
        }
    }
}