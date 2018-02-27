namespace VendingMachine
{
    public class CoinPayment : Payment
    {
        private const double coinValue = 0.5;
        
        public override double[] AcceptedMonetaryUnits { get; } = new double[] { 0.5, 1, 5, 10 };

        public override string GetChange(double price)
        {
            double change = AmountPaid - price;
            AmountPaid = price;
            int nrCoins = (int)(change / coinValue);

            return change == 0 ? "Change: 0" : $"Change: {change} ({nrCoins}x{coinValue})";
        }

        public string GetRefund()
        {
            int nrCoins = (int)(AmountPaid / coinValue);
            string refund = AmountPaid == 0 ? "Refunded: 0" : $"Refunded: {AmountPaid} ({nrCoins}x{coinValue})";
            AmountPaid = 0;

            return refund;
        }
    }
}