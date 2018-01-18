using System;

namespace VendingMachine
{
    public abstract class Payment
    {
        public abstract double Change(double paid, double price);
    }
}