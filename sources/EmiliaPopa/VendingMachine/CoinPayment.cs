using System;
namespace VendingMachine
{
    public class CoinPayment : Payment {    
        public override double MoneyPaid { get; set; }

         public override double change (double moneyPaid, double price){
             return moneyPaid-price;
         }


    }

}

