using System;

namespace VendingMachine
{
    public class CoinPayment : Payment
    {
         public override double Change(double paid, double price)
        {
          return paid - price;
          
        }
    }
}