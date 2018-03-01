using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Position pos1 = new Position(3, 5, 1, 1);
            Position pos2 = new Position(2, 4, 5, 2);
            ProductCategory pc1 = new ProductCategory("snacksuri");
            ProductCategory pc2 = new ProductCategory("sucuri");
            Product p1 = new Product(pos1, "lays", 4, 2.5, pc1);
            Product p2 = new Product(pos2, "cola", 0, 5.1, pc2);
            ContainableItem ci1 = new ContainableItem(pos1, p1);
            ContainableItem ci2 = new ContainableItem(pos2, p2);
            ContainableItemsCollection collection = new ContainableItemsCollection();
            collection.Add(ci1);
            collection.Add(ci2);
            Dispenser dispenser=new Dispenser(collection);
            //dispenser.Dispense(1);
            Payment payment=new BanknotePayment(6);
            PaymentTerminal paymentTerminal=new PaymentTerminal(dispenser);
            paymentTerminal.Pay(1,payment);
            dispenser.PrintReport();


        }
    }
}
