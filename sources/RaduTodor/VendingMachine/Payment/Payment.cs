using System;

namespace VendingMachine
{
    public abstract class Payment
    {
        public abstract Boolean Change(double price);

        public Boolean IsValid;

        public double Accumulate = 0;
    }
}