using System;
using System.Collections.Generic;

namespace VendingMachine
{
   public  class Program
    {
       
        static void Main(string[] args)
        {            
            int paymentType=0;
            ContainableItem lays = new ContainableItem(new Product(new ProductCategory("Snacks"),"Lays",5,10,3),new Position(1,1,2,2));
            ContainableItem M_m = new ContainableItem(new Product(new ProductCategory("Sweets"),"M&M",3,20,1),new Position(2,1,1,1));
            ContainableItem milk = new ContainableItem(new Product(new ProductCategory("Milk Products"),"Milk",2,40,2),new Position(3,1,2,3));

            ContainableItemsCollection.AddItem(lays);
            ContainableItemsCollection.AddItem(M_m);
            ContainableItemsCollection.AddItem(milk);

            ContainableItemsCollection.ShowList();
/* 
            ContainableItem item = new ContainableItem();
            Console.WriteLine("GetItem");
            item=ContainableItemsCollection.GetItem(0);
            Console.WriteLine(item);

            Console.WriteLine("Count is "+ContainableItemsCollection.Count());

            Console.WriteLine("Remove");
            ContainableItemsCollection.RemoveItem(M_m);

            try
            {
            Console.WriteLine("RemoveByPostition");
            ContainableItemsCollection.RemoveByPosition(new Position(1,1,2,2));
            }
            catch(Exception e){ Console.WriteLine(e);}

            try
            {
                Product  dispenseItem =Dispenser.Dispense(3);
                Console.WriteLine("DispenseProduct:"+dispenseItem);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
           
            Console.WriteLine("ShowList: "+"Number of elements left:"+ContainableItemsCollection.Count());
            ContainableItemsCollection.ShowList(); 
            */
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
                 PaymentTerminal payConsole = new PaymentTerminal();
                 payConsole.Pay(1,payCoin);
                 break;
                 case 2:
                 Payment payBanknote = new Banknote();
                 PaymentTerminal payConsole2 = new PaymentTerminal();
                 payConsole2.Pay(1,payBanknote);
                 break;
                 case 3:
                 Payment payCreditCard = new CreditCard();
                 PaymentTerminal payConsole3 = new PaymentTerminal();
                 payConsole3.Pay(1,payCreditCard);
                 break;
                default:
                break;
            }
           


        }
        
    }
}
