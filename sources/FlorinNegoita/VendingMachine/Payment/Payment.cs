using System;

namespace VendingMachine
{
    public abstract class Payment
    {
        public abstract double Change(double price);
        
      //  public abstract Decimal Accumulate(decimal amount);

       public double Accumulate = 100;

        public Boolean IsValid;
    }
}