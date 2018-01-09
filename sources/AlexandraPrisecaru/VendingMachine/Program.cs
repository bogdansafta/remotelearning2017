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
            VendingMachine vendingMachine = VendingMachine.Instance;

            Product coffeeProduct = new Product()
            {
                Category = new Category("Beverages"),
                Name = "Coffee",
                Price = 12.3,
                Position = new Position(row: 0, column: 0, id: 1)
            };

            Console.WriteLine("Add a product:");
            vendingMachine.Items.Add(coffeeProduct);
            WriteContainableItems(vendingMachine.Items);

            Console.WriteLine("Add multiple products:");
            vendingMachine.Items.AddRange(
                new Product
                {
                    Category = new Category("Beverages"),
                    Name = "Cola",
                    Price = 12.5,
                    Position = new Position(row: 0, column: 1, id: 2)
                },
                new Product
                {
                    Category = new Category("Snacks"),
                    Name = "Chips",
                    Price = 10.5,
                    Position = new Position(row: 0, column: 2, id: 2, size: 2)
                },
                new Product
                {
                    Category = new Category("Snacks"),
                    Name = "Chips",
                    Price = 10.5
                },
                new Product
                {
                    Category = new Category("Beverages"),
                    Name = "Sprite",
                    Price = 8.5,
                    Position = new Position(row: 1, column: 2, id: 5)
                }
            );
            WriteContainableItems(vendingMachine.Items);

            Console.WriteLine("Remove at position: 0,1");
            if (!vendingMachine.Items.RemoveBy(new Position(row: 0, column: 1, id: 2)))
            {
                Console.WriteLine("No product found at this position.");
            }
            else
            {
                WriteContainableItems(vendingMachine.Items);
            }

            Console.WriteLine("Search for a coffee product:");
            try
            {
                if (vendingMachine.Items.Contains(coffeeProduct))
                {
                    Console.WriteLine(coffeeProduct.ToString());
                    Console.WriteLine("\nCoffee product was found and it will be removed.");
                    vendingMachine.Items.Remove(coffeeProduct);
                    WriteContainableItems(vendingMachine.Items);
                }
            }
            catch
            {
                Console.WriteLine("Product not found.");
            }

            Console.WriteLine("Remove second product: ");
            try
            {
                vendingMachine.Items.RemoveAt(1);
                WriteContainableItems(vendingMachine.Items);
            }
            catch
            {
                Console.WriteLine("Product not found.");
            }

            Product beverageProduct = vendingMachine.Items.FirstOrDefault(containableItem => (containableItem as Product).Category.Name.Equals("Beverages")) as Product;

            Console.WriteLine("Search for the first beverage product using linq:");

            string beverageMessage = beverageProduct == null
            ? "No beverage found"
            : $"Beverage Found:\t{beverageProduct.ToString()}";

            Console.WriteLine(beverageMessage);

            try
            {
                Console.WriteLine($"\nLast product:\t{vendingMachine.Items.GetItem(vendingMachine.Items.Count - 1)}");
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
