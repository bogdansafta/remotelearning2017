using System;
namespace VendingMachine
{
    public class CreditCardPayment : Payment 
    {
         public override double MoneyPaid { get; set; }

         public override double change (double moneyPaid, double price){
             return 0;
         }

    }
}