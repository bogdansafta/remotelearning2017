using System;
namespace VendingMachine
{
    abstract class Payment{
       public abstract double MoneyPaid { get; set; }

       public abstract double change (double moneyPaid, double price);

   }
}