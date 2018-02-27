using System;
using System.Linq;

namespace VendingMachine
{
    public class Program
    {
        private const string invalidInput = "Invalid input";

        static void Main(string[] args)
        {
            PaymentTerminal paymentTerminal = new PaymentTerminal();

            Payment payment = paymentTerminal.GetPayment();
            Console.WriteLine($"Payment type selected: {payment.ToString()}");

            Console.WriteLine("\nAvailable products:");
            foreach (ContainableItem containableItem in VendingMachine.Instance.Items)
            {
                Console.WriteLine($"Id: {containableItem.Position.Id}\t ProductName: {containableItem.Product.Name}"
                + "\t Price: {containableItem.Product.Price}");
            }

            int id = GetSelectedId();

            paymentTerminal.Pay(id, payment);
            Console.ReadKey();
        }

        private static void ContainableItemCollectionFunctionalities()
        {
            VendingMachine vendingMachine = VendingMachine.Instance;

            Product coffeeProduct = new Product()
            {
                Category = new Category("Beverages"),
                Name = "Coffee",
                Price = 12.3,
            };

            Console.WriteLine("Add a product:");
            vendingMachine.Items.Add(new ContainableItem
            {
                Product = coffeeProduct,
                Position = new Position(row: 2, column: 0, id: 13, size: 3)
            });

            WriteContainableItems(vendingMachine.Items);

            Console.WriteLine("Remove at position: (0,1)");
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
                ContainableItem coffeeContainableItem = vendingMachine.Items.FirstOrDefault(containableItem => containableItem.Product.Equals(coffeeProduct));
                if (coffeeContainableItem != null)
                {
                    Console.WriteLine(coffeeProduct.ToString());
                    Console.WriteLine("\nCoffee product was found and it will be removed.");
                    vendingMachine.Items.Remove(coffeeContainableItem);
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

            Product beverageProduct = vendingMachine.Items.FirstOrDefault(containableItem => containableItem.Product.Category.Name.Equals("Beverages"))?.Product;

            Console.WriteLine("Search for the first beverage product using linq:");

            string beverageMessage = beverageProduct == null
            ? "No beverage found"
            : $"Beverage Found:\t{beverageProduct.ToString()}";

            Console.WriteLine(beverageMessage);

            try
            {
                ContainableItem lastProduct = vendingMachine.Items.GetItem(vendingMachine.Items.Count - 1);
                Console.WriteLine($"\nLast product:\t{vendingMachine.Items.GetItem(vendingMachine.Items.Count - 1).Product}");
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
                Console.WriteLine(containableItem.Product.ToString());
            }

            Console.WriteLine();
        }

        private static int GetSelectedId()
        {
            Console.WriteLine("\nSelect an id:");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine(invalidInput);
                return GetSelectedId();
            }

            if (!VendingMachine.Instance.Items.Any(item => item.Position.Id == id))
            {
                Console.WriteLine(invalidInput);
                return GetSelectedId();
            }

            return id;
        }
    }
}
