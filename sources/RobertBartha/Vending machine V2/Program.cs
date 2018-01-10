using System;

namespace Vending_machine_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ContainableItem> list = new List<ContainableItem>();
            Position position = new Position(1, 1, 1, 2);
            ProductCategory productType = new ProductCategory("Ciocolata");
            Product product = new Product(position, productType, 1, "Milka", 12, 1);
            list.Add(product);
            for (int i = 0; i < list.count; i++)
            {
                Console.WriteLine(list);
            }
            list.Remove(product);
        }
    }
}
