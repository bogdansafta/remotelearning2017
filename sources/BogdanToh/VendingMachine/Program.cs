using System;
using System.Collections.Generic;

namespace VendingMachine
{
   public  class Program
    {
       
        static void Main(string[] args)
        {            
            int paymentType=0;
             PaymentTerminal payConsole = new PaymentTerminal();
            ContainableItem lays = new ContainableItem(new Product(new ProductCategory("Snacks"),"Lays",50,10,3),new Position(1,1,2,2));
            ContainableItem M_m = new ContainableItem(new Product(new ProductCategory("Sweets"),"M&M",30,20,1),new Position(2,1,1,1));
            ContainableItem milk = new ContainableItem(new Product(new ProductCategory("Milk Products"),"Milk",20,40,2),new Position(3,1,2,3));

            ContainableItemsCollection.AddItem(lays);
            ContainableItemsCollection.AddItem(M_m);
            ContainableItemsCollection.AddItem(milk);
            Dispenser dispenser = new Dispenser();
           // payConsole.Subscribe(dispenser);
           // PaymentTerminal.Subscriber ceva = new PaymentTerminal.Subscriber();
            CreditCardVerification cd = new CreditCardVerification();
            cd.validate();

            ContainableItemsCollection.ShowList();
            Console.WriteLine("How do you want to pay? 1-Coins, 2-Banknote, 3-CreditCard, 0-Back");
            try
            {
            paymentType =Int32.Parse(Console.ReadLine());
            }
            catch(Exception e){ Console.WriteLine(e);}

            switch (paymentType)
            {
                 case 1:
                 Payment payCoin = new Coin();
                 payConsole.Pay(1,payCoin);
                 break;
                 case 2:
                 Payment payBanknote = new Banknote();
                 payConsole.Pay(1,payBanknote);
                 break;
                 case 3:
                 Payment payCreditCard = new CreditCard();
                 payConsole.Pay(1,payCreditCard);
                 break;
                default:
                break;
            }
           


        }
        
    }
}
