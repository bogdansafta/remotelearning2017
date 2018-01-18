using System;

namespace VendingMachine
{
    public class CreditCardPayment : Payment
    {
        public override double Change(double paid, double price)
        {
            return paid - price;
        }
    }
}