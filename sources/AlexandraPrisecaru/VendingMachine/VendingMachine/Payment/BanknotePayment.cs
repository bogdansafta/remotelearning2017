namespace VendingMachine
{
    public class BanknotePayment : CoinPayment
    {
        public override double[] AcceptedMonetaryUnits { get; } = new double[] { 1, 5, 10 };
    }
}