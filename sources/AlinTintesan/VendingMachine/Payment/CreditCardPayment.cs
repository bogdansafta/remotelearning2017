using System;

namespace VendingMachine
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(double paid)
        {
            this.Paid=paid;
        }
        public override double Change(double price) 
        {
            Random random=new Random();
            int randomNumber=random.Next(0,2);
            if(randomNumber==0)
                return 0;
            else
                throw new CreditCardRejectedException();
        }

        public override double Refund => this.Paid;
    }
}