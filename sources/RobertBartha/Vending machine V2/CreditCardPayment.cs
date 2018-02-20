using System;

namespace Vending_machine_V2
{
    public class CreditCardPayment : Payment
    {
        float paid = 0;
        public override bool Change(double price)
        {
            return true;
        }
        public override bool IsValid(Product product)
        {
            if (product.price == paid)
                return true;
            return false;
        }
    }
}