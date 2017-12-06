using System;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product()
            {
                Type = "Ciocolata",
                Name = "Milka",
                Price = 4.2,
                Quantity = 10,
                Size = 10
            };

            Product product2 = new Product()
            {
                Type = "Suc",
                Name = "Sprite",
                Price = 6.5,
                Quantity = 10,
                Size = 2
            };

            Product product3 = new Product()
            {
                Type = "Chips",
                Name = "Lays",
                Price = 2.2,
                Quantity = 10,
                Size = 3
            };

            ProductCollection productCollection = new ProductCollection();
            productCollection.AddProduct(product1);
            productCollection.AddProduct(product2);
            productCollection.AddProduct(product3);

            productCollection.Remove(product2);

            for (int i = 0; i < productCollection.Count(); i++)
            {
                Console.WriteLine(productCollection.GetItem(i).Name);
            }
        }
    }
}
