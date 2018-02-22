using System.Linq;
using System;
namespace VendingMachine
{
    public class CreditCard : Payment
    {  
         protected string CardNumber{get;set;}

        protected string CardNumberValue(int length)
        {
        
        const string chars = "123456789";
        Random random = new Random();
        return new string(Enumerable.Repeat(chars, length)
        .Select(s => s[random.Next(s.Length)]).ToArray());

        }
        public override bool IsValid {get;protected set ;}
        public override double change(double monneyOnCard, double price)
        {
            IsValid=false;
           if(monneyOnCard>=price)
           {
               IsValid=true;
           }
            return monneyOnCard-price;
        }
    }
}