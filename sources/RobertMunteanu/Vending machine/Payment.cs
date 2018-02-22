using System;
namespace VendingMachine
{
    public abstract class Payment
    {        
        
        public Decimal Change(Decimal paid, Decimal price)
        {
            Decimal change = paid - price;
            return change;
        }
    }
}