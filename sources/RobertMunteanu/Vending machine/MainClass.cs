using System;
using System.Collections.Generic;

namespace VendingMachine
{
    class MainClass
    {
        static private ContainableItemCollection collection;
        static private ContainableItem[] itemArray;
        static private Dispenser dispenser;
        static PaymentTerminal paymentTerminal;

        static private void DeclarationsAndInitializations()
        {
            itemArray = new ContainableItem[] {
                new ContainableItem(new Product("Poiana cu lapte",5.2m,new Category("mancare"),5), new Position(1,1,1,1)),
                new ContainableItem(new Product("Nestea 0.5L",10m,new Category("bautura"),2), new Position(1,2,2,2)),
                new ContainableItem(new Product("Pepsi 0.5L",4.6m,new Category("bautura"),53), new Position(1,3,1,3)),
                new ContainableItem(new Product("Mouse PC",30.6m,new Category("altele"),17), new Position(2,1,1,4))
            };
            collection = new ContainableItemCollection(itemArray);
            dispenser = new Dispenser(collection);
            paymentTerminal = new PaymentTerminal();
        }

        static private Decimal MenuFlow(int Id)
        {
            if (Id == 0)
                return 0;
            return collection.ItemById(Id).Product.Price;
        }
        static private void DisplayMenu()
        {
            System.Console.WriteLine("Salut! Alege ID-ul produsului pentru a il achizitiona: ");
            System.Console.WriteLine("0. Iesire din program");
            for (int index = 0; index < collection.Count; index++)
            {
                System.Console.WriteLine($"{collection.ItemByIndex(index).Position.Id}. {collection.ItemByIndex(index).Product.Name} , pret: {collection.ItemByIndex(index).Product.Price}");
            }
        }

        static private void PaymentFlow(int i)
        {
            System.Console.WriteLine("Alegeti modalitatea de plata:");
            System.Console.WriteLine("1. Card");
            System.Console.WriteLine("2. Bancnote");
            System.Console.WriteLine("3. Monede");
            switch(i)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }
        static void Main(string[] args)
        {

            DeclarationsAndInitializations();
            DisplayMenu();
            paymentTerminal = new PaymentTerminal(dispenser);
            string ProductIdString;
            int ProductId = -1;
            while (ProductId != 0)
            {
                if (ProductId == 0)
                {
                    break;
                }
                ProductIdString = Console.ReadLine();
                ProductId = Convert.ToInt32(ProductIdString);
                System.Console.WriteLine($"Trebuie sa platiti {MenuFlow(ProductId)}");

            }






        }
    }
}