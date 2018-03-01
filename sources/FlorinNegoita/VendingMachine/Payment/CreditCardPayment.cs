using System;

namespace VendingMachine
{
    public class CreditCardPayment : Payment
    {
        public override double Accumulate(double price)
        {
          throw new NotImplementedException();
        }

        public override double Change(double price)
        {
            IsValid = true;
            return price;
        }
    }
}