using System;

namespace VendingMachine
{
    public class Coin : Payment
    {   
        
        public override double change(int paid,double price)
        {

            /* 
            double paid=0,pay=0;
            Console.WriteLine("Insert coins:");
            int insertMoney=80;
            if(insertMoney%10==0)
            {
                while(paid<price)
                {
                    paid=paid+insertMoney;
                    if(paid>price)
                    break;
                    Console.WriteLine("The sum inserted is not enough,you still need:"+(price-paid)+"coins");
                }
            }
            else
            {
                Console.WriteLine("Insert a proper sum");
            }
                */


            return paid-price;
           
        }
    }
}