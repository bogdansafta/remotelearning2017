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

            ContainableItem first = new Product(new Position(0, 0, 3), "Candybar", 10.3f, 6, candyCategory);
            ContainableItem second = new Product(new Position(0, 1, 2), "Bubblegum", 5.221111111111f, 10, candyCategory);
            ContainableItem third = new Product(new Position(0, 2, 1), "Toothpick", 1f, 999, utilityCategory);

            col.Add(first);
            col.Add(second);
            col.Add(third);

            for (int i = 0; i < col.Count; i++)
            {
                System.Console.WriteLine(col[i]);
            }

            System.Console.WriteLine("Removing second element...");
            col.Remove(second);

            for (int i = 0; i < col.Count; i++)
            {
                System.Console.WriteLine(col[i]);
            }

            Position pos = new Position(0, 0, 3);
            System.Console.WriteLine($"Removing element with position:{pos}");
            col.RemoveByPosition(pos);

            for (int i = 0; i < col.Count; i++)
            {
                System.Console.WriteLine(col[i]);
            }
        }
    }
}
