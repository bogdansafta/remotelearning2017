using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product=new Product();
            product.Category=new ProductCategory("SWEETS");
            product.Name="Milka";
            product.Price=5;
            product.Size=1;
            Position position= new Position(2,2,1, 29);
            ContainableItem containableItem= new ContainableItem(position, product);
            
            Product product2=new Product();
            product2.Category=new ProductCategory("Snacks");
            product2.Name="Lays";
            product2.Price=3;
            product2.Size=1;
            Position position2= new Position(2,2,1, 25);
            ContainableItem containableItem2= new ContainableItem(position2, product2);
            
            ContainableItemCollection collection= new ContainableItemCollection();
            collection.add(containableItem);
            collection.add(containableItem2);
            Dispenser dispenser=new Dispenser(collection);

            Console.WriteLine(dispenser.dispense(29).Name);
            
        }
    }
}
