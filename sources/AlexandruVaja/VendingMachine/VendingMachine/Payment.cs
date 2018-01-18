using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public abstract class Payment
    {
        public double paid;
        public double price;

        public double Change(double paid, double price)
        {
            return paid - price;
        }
    }
}
