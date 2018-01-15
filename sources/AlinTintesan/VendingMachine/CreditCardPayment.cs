using System;

namespace VendingMachine
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(double paid)
        {
            this.Paid=paid;
        }
        public override double Change(double price) => this.Paid-price;

        public override double Refund => this.Paid;
    }
}