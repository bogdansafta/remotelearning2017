using System;

namespace VendingMachine
{
    public abstract class Payment
    {
        public abstract double Change(double price);
        
       public abstract double Accumulate(double price);

      // public double Accumulate = 100;

        public Boolean IsValid;
    }
}