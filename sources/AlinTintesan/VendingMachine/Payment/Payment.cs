using System;

namespace VendingMachine
{
    public abstract class Payment
    {
        public double Paid { get; set; }
        public abstract double Change(double price);

        public abstract double Refund { get; }
    }
}