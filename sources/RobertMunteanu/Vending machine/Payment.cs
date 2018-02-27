using System;
namespace VendingMachine
{
    public abstract class Payment
    {        

        public Decimal Accumulate = 0;
        public Boolean IsValid(Decimal price)
        {
            return (Accumulate - price >= 0);
        }

        public Decimal Change(Decimal price)
        {
            Decimal change = Accumulate - price;
            return change;
        }
    }
}