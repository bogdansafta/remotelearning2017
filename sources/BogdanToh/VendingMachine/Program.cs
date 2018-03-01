using System;
using System.Collections.Generic;

namespace VendingMachine {
    public class Program {

        static void Main (string[] args) {
            int paymentType=0 ,id=0 ,moreProducts=1;
            PaymentTerminal payConsole = new PaymentTerminal ();
            ContainableItem lays = new ContainableItem (new Product (new ProductCategory ("Snacks"), "Lays", 50, 10, 3), new Position (1, 1, 2, 2));
            ContainableItem M_m = new ContainableItem (new Product (new ProductCategory ("Sweets"), "M&M", 30, 20, 1), new Position (2, 1, 1, 1));
            ContainableItem milk = new ContainableItem (new Product (new ProductCategory ("Milk Products"), "Milk", 20, 40, 2), new Position (3, 1, 2, 3));

            ContainableItemsCollection.AddItem (lays);
            ContainableItemsCollection.AddItem (M_m);
            ContainableItemsCollection.AddItem (milk);

            ContainableItemsCollection.ShowList ();
            while (moreProducts!=0) {
                try {
                    Console.WriteLine ("Product id:");
                    id = Int32.Parse (Console.ReadLine ());
                    Console.WriteLine ("How do you want to pay? 1-Coins, 2-Banknote, 3-CreditCard, 0-Back");
                    paymentType = Int32.Parse (Console.ReadLine ());
                } catch (Exception e) { Console.WriteLine (e); }

                switch (paymentType) {
                    case 1:
                        Payment payCoin = new Coin ();
                        payConsole.Pay (id, payCoin);
                        break;
                    case 2:
                        Payment payBanknote = new Banknote ();
                        payConsole.Pay (id, payBanknote);
                        break;
                    case 3:
                        Payment payCreditCard = new CreditCard ();
                        payConsole.Pay (id, payCreditCard);
                        break;
                    default:
                        break;
                }
                try {
                    Console.WriteLine ("Do you want to buy another product? 1-Yes 0-No");
                    moreProducts = Int32.Parse (Console.ReadLine ());
                } catch (Exception e) { Console.WriteLine (e); }
            }
        }

    }
}