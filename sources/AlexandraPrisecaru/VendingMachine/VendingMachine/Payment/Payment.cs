namespace VendingMachine
{
    public abstract class Payment
    {
        public double AmountPaid { get; set; }
        public virtual double[] AcceptedMonetaryUnits { get; }
        public abstract string GetChange(double price);

        public override string ToString() => GetType().Name;
    }
}
