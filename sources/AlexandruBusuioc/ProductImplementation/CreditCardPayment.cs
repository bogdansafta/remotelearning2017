using System;
namespace ProductImplementation
{
    public class CreditCardPayment : Payment
    {
        public override int GiveChange(int value)
        {
            return 0;
        }
        public override int InsertMoney()
        {
            return 0;
        }
    }
}