namespace VendingMachine
{
    public abstract class Payment
    {
        public abstract double AmountPaid { get; set; }
        
        public abstract double GetChange(double amountPaid, double price);
    }
}
