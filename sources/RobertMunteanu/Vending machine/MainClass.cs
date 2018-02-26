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
                new ContainableItem(new Product("Timisoreana 2,5L",10m,new Category("bautura"),2), new Position(1,2,2,2)),
                new ContainableItem(new Product("Pepsi 0.5L",4.6m,new Category("bautura"),53), new Position(1,3,1,3)),
                new ContainableItem(new Product("Mouse PC",30.6m,new Category("altele"),17), new Position(2,1,1,4))
            };
            collection = new ContainableItemCollection(itemArray);
            dispenser = new Dispenser(collection);
            paymentTerminal = new PaymentTerminal();
        }

        static private Decimal MenuFlow(ContainableItem[] itemArray, int Id)
        {
            
            return itemArray[Id].Product.Price;
        }
        static private void DisplayMenu(ContainableItem[] itemArray)
        {
            System.Console.WriteLine("Salut! Alege ID-ul produsului pentru a il achizitiona: ");
            System.Console.WriteLine("0. Iesire din program");
            for (int index = 0; index < itemArray.Length; index++)
            {
                System.Console.WriteLine($"{itemArray[index].Position.Id}. {itemArray[index].Product.Name} , pret: {itemArray[index].Product.Price}" );
            }
        }
        static void Main(string[] args)
        {
            DeclarationsAndInitializations();
            DisplayMenu(itemArray);
            int ProductId = Console.Read();
            while (ProductId != 0)
            {
                MenuFlow(itemArray, ProductId);
                ProductId = Console.Read();
            }

        }
    }
}