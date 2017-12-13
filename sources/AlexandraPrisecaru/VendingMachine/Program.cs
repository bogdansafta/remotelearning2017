using System;
using System.Linq;

namespace VendingMachine
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContainableItemCollectionFunctionalities();
        }

        private static void ContainableItemCollectionFunctionalities()
        {
            ContainableItemCollection containableItemCollection = new ContainableItemCollection();
            Product coffeeProduct = new Product()
            {
                Category = Category.Beverages,
                Name = "Coffee",
                Price = 12.3,
                Position = new Position()
                {
                    Row = 0,
                    Column = 0
                }
            };

            Console.WriteLine("Add a product:");
            containableItemCollection.Add(coffeeProduct);
            WriteContainableItems(containableItemCollection);

            Console.WriteLine("Add multiple products:");
            containableItemCollection.AddRange(
                new Product
                {
                    Category = Category.Beverages,
                    Name = "Cola",
                    Price = 12.5,
                    Position = new Position
                    {
                        Row = 0,
                        Column = 1
                    }
                },
                new Product
                {
                    Category = Category.Snacks,
                    Name = "Chips",
                    Price = 10.5,
                    Position = new Position
                    {
                        Row = 0,
                        Column = 2, 
                        Size = 2
                    }
                },
                new Product
                {
                    Category = Category.Snacks,
                    Name = "Chips",
                    Price = 10.5
                },
                new Product
                {
                    Category = Category.Beverages,
                    Name = "Sprite",
                    Price = 8.5,
                    Position = new Position
                    {
                        Row = 1,
                        Column = 2
                    }
                }
            );
            WriteContainableItems(containableItemCollection);

            Console.WriteLine("Remove at position: 0,1");

            try
            {
                containableItemCollection.RemoveBy(new Position(0, 1));
            }
            catch
            {
                Console.WriteLine("No product found at this position.");
            }

            WriteContainableItems(containableItemCollection);

            Console.WriteLine("Search for a coffee product:");
            try
            {
                if (containableItemCollection.Contains(coffeeProduct))
                {
                    Console.WriteLine(coffeeProduct.ToString());
                    Console.WriteLine("\nCoffee product was found and it will be removed.");
                    containableItemCollection.Remove(coffeeProduct);
                    WriteContainableItems(containableItemCollection);
                }
            }
            catch
            {
                Console.WriteLine("Product not found.");
            }

            Console.WriteLine("Remove second product: ");
            try
            {
                containableItemCollection.RemoveAt(1);
                WriteContainableItems(containableItemCollection);
            }
            catch
            {
                Console.WriteLine("Product not found.");
            }

            Product beverageProduct = containableItemCollection.FirstOrDefault(containableItem => (containableItem as Product).Category == Category.Beverages) as Product;

            Console.WriteLine("Search for the first beverage product using linq:");

            string beverageMessage = beverageProduct == null
            ? "No beverage found"
            : $"Beverage Found:\t{beverageProduct.ToString()}";

            Console.WriteLine(beverageMessage);

            try
            {
                Console.WriteLine($"\nLast product:\t{containableItemCollection.GetItem(containableItemCollection.Count - 1)}");
            }
            catch
            {
                Console.WriteLine("Product not found.");
            }
        }

        private static void WriteContainableItems(ContainableItemCollection containableItemCollection)
        {
            foreach (ContainableItem containableItem in containableItemCollection)
            {
                Console.WriteLine((containableItem as Product).ToString());
            }
            Console.WriteLine();
        }
    }
}
