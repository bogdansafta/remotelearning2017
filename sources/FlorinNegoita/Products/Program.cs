using System;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductCategory productCategory1 = new ProductCategory()
            {
                Name = "Ciocolata"
            };

             ProductCategory productCategory2 = new ProductCategory()
            {
                Name = "Suc"
            };

            Position position1 = new Position()
            {
                Row = 1,
                Column = 2,
                Size = 3
            };

            Position position2 = new Position()
            {
                Row = 2,
                Column = 1,
                Size = 4
            };

             ContainableItem containableItem1 = new Product()
            {
               Position = position2,
               Category = productCategory1,
               Price = 4.5,
               Quantity = 3,
               Name = "Milka"
            };

            ContainableItem containableItem2 = new Product()
            {
               Position = position1,
               Category = productCategory2,
               Price = 6.3,
               Quantity = 2,
               Name = "Sprite"
            };

             ContainableItem containableItem3 = new Product()
            {
               Position = position1,
               Category = productCategory1,
               Price = 3.1,
               Quantity = 1,
               Name = "Poiana"
            };

            ContainableItemsCollection containableItemsCollection = new  ContainableItemsCollection();
            containableItemsCollection.AddProduct(containableItem1);
            containableItemsCollection.AddProduct(containableItem2);
            containableItemsCollection.AddProduct(containableItem3);

            containableItemsCollection.RemoveAt(2);

            for (int i = 0; i < containableItemsCollection.Count(); i++)
            {
                Console.WriteLine(containableItemsCollection.GetItem(i));
            }
        }
    }
}
