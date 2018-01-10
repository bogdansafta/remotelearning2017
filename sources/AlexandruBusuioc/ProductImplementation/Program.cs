using System;
using System.Collections.Generic;
namespace ProductImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            ContainableItemsCollection col = new ContainableItemsCollection();

            ProductCategory candyCategory = new ProductCategory("Candy");
            ProductCategory utilityCategory = new ProductCategory("Utility");
            
            Product candybar = new Product("Candybar", 10.3f, 6, candyCategory);
            Product bubblegum =  new Product("Bubblegum", 5.221111111111f, 10, candyCategory);
            Product toothpick = new Product("Toothpick", 1f, 999, utilityCategory);

            ContainableItem first = new ContainableItem(new Position(0,0,1,0),candybar);
            ContainableItem second = new ContainableItem(new Position(0,1,2,1),bubblegum);
            ContainableItem third = new ContainableItem(new Position(0,2,1,2),toothpick);

            col.Add(first);
            col.Add(second);
            col.Add(third);

            Dispenser dispenser = new Dispenser(col);

            for (int i = 0; i < col.Count; i++)
            {
                System.Console.WriteLine(col[i]);
            }

            dispenser.Dispense(1);

            for (int i = 0; i < col.Count; i++)
            {
                System.Console.WriteLine(col[i]);
            }

            dispenser.Dispense(2);

            for (int i = 0; i < col.Count; i++)
            {
                System.Console.WriteLine(col[i]);
            }

            dispenser.Dispense(6);

            for (int i = 0; i < col.Count; i++)
            {
                System.Console.WriteLine(col[i]);
            }

            dispenser.Dispense(0);

            for (int i = 0; i < col.Count; i++)
            {
                System.Console.WriteLine(col[i]);
            }

            dispenser.Dispense(0);

            for (int i = 0; i < col.Count; i++)
            {
                System.Console.WriteLine(col[i]);
            }

        }
    }
}
