using System;

namespace VendingMachine
{
    public class CreditCardPayment : Payment
    {
        public override string GetChange(double price) => string.Empty;

        public bool IsValid()
        {
            return new Random().Next(2) == 1;
        }
    }
}