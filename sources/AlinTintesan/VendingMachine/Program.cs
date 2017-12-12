using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Position pos1 = new Position(3, 5, 1);
            Position pos2 = new Position(2, 4, 5);
            ProductCategory pc1 = new ProductCategory("Ciocolata");
            ContainableItem ci1 = new Product(pos1, "ci1", 5, 2.3, pc1);
            ContainableItem ci2 = new Product(pos2, "ci2", 32, 54.3, pc1);
            ContainableItem ci3 = new Product(pos2, "ci3", 32, 54.3, pc1);
            ContainableItem ci4 = new Product(pos2, "ci4", 32, 54.3, pc1);
            ContainableItem ci5 = new Product(pos2, "ci5", 32, 54.3, pc1);
            ContainableItem ci6 = new Product(pos2, "ci6", 32, 54.3, pc1);
            ContainableItem ci7 = new Product(pos2, "ci7", 32, 54.3, pc1);
            ContainableItemsCollection collection = new ContainableItemsCollection();
            collection.Add(ci1);
            collection.Add(ci2);
            collection.Add(ci3);
            collection.Add(ci4);
            collection.Add(ci5);
            collection.Add(ci6);
            collection.Add(ci7);
            //Console.WriteLine(collection.Get(1));
            collection.Remove(ci4);
            collection.ShowItems();
        }
    }
}
