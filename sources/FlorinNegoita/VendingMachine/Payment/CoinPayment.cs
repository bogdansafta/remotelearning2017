using System;

namespace VendingMachine
{
    public class CoinPayment : Payment
    {
        public override double Change(double price)
        {
            return Accumulate - price;
        }
    }
}