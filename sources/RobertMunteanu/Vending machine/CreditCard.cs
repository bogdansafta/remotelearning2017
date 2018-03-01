using System;

namespace VendingMachine
{
    public class CreditCard : Payment
    {
        public CreditCard(int Pin)
        {
            this.Pin = Pin;
        }
        public Decimal Value { get; set; }
        public int Pin {get; private set;}
    }
}