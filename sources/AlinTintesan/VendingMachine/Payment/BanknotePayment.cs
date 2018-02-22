using System;

namespace VendingMachine
{
    public class BanknotePayment : Payment
    {
        public BanknotePayment(double paid)
        {
            this.Paid=paid;
        }
        public override double Change(double price) => this.Paid-price;

        public override double Refund => this.Paid;
    }

}