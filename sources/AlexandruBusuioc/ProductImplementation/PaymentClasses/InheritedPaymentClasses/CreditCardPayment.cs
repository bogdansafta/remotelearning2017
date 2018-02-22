using System;
namespace ProductImplementation
{
    public class CreditCardPayment : Payment
    {
        //Credit Card should be validated, no change returned
        // Verified by a mocked component
        private CreditCard card;
        public CreditCardPayment(CreditCard card)
        {
            this.card = card;
        }
        public override int GiveChange(int value)
        {
            return 0;
        }
        public override int InsertMoney()
        {
            return 0;
        }
        public bool Verify()
        {
            return card.Verify();
        }
        
    }
}