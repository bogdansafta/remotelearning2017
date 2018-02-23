using System;

namespace VendingMachine
{
    public class CreditCardPayment : Payment
    {
        public override double Change(double price)
        {
            return Accumulate - price;
        }
    }
}