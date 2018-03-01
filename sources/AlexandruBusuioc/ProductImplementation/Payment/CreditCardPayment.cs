using System;
namespace ProductImplementation
{
    public class CreditCardPayment : Payment
    {
        private CreditCard card;
        public CreditCardPayment(decimal toPay, CreditCard card) : base(toPay)
        {
            this.card = card;
        }
        public override bool IsValid()
        {
            return (toPay <= 0);
        }
        public override decimal Accumulate()
        {
            if (card.Verify())
            {
                decimal paid = toPay;
                toPay = 0;
                return paid; 
            }
            else
                return -1;
        }
        public override decimal GiveChange(decimal paid)
        {
            return 0;
        }
        
    }
}