using System;

namespace VendingMachine
{
    public abstract class Payment
    {
        public abstract Boolean Change(double price);
    }
}