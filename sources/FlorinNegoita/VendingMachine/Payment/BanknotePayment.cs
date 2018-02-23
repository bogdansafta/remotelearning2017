using System;

namespace VendingMachine
{
    public class BanknotePayment : Payment
    {
        // public override decimal Accumulate(decimal amount)
        // {
        //   
        // }

        public override double Change(double price)
        {
          return Accumulate - price;          
        }
    }
}