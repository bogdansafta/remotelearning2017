using System;

namespace VendingMachine
{
    public class BanknotePayment : Payment
    {
        public override double Change(double paid, double price)
        {
          return paid - price;
          
        }
    }
}