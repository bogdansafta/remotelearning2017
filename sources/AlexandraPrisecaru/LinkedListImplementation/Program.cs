using System;
using System.Linq;

namespace LinkedListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            MyListFunctionalities();
            ProductCollectionFunctionalities();
        }

        private static void MyListFunctionalities()
        {
            LinkedList<Product> products = new LinkedList<Product>();
            Product coffeeProduct = new Product()
            {
                Category = Category.Beverages,
                Name = "Coffee",
                Price = 5
            };
            products.Add(coffeeProduct);

            products.AddAtStart(
                new Product
                {
                    Category = Category.Beverages,
                    Name = "Cola",
                    Price = 12.5
                }
            );

            products.RemoveAt(1);

            Console.WriteLine("Example using list directly:\n");
            foreach (Product product in products)
            {
                Console.WriteLine(product.ToString());
            }
        }

        private static void ProductCollectionFunctionalities()
        {
            ProductCollection productCollection = new ProductCollection();
            productCollection.Add(
                new Product
                {
                    Category = Category.Beverages,
                    Name = "Cola",
                    Price = 12.5
                });
            productCollection.Add(
                new Product
                {
                    Category = Category.Snacks,
                    Name = "Chips",
                    Price = 10.5
                });

            
            Console.WriteLine("\nExample using product Collection:\n");

            Product beverageProduct = productCollection.FirstOrDefault(product => product.Category == Category.Beverages);
            Console.WriteLine($"Beverage:\t{beverageProduct?.ToString()}");

            Product lastProduct = productCollection.GetItem(productCollection.Count-1);
            Console.WriteLine($"Last product:\t{lastProduct}");
            
            Console.WriteLine("\nProducts in productCollection:");
            foreach (Product product in productCollection)
            {
                Console.WriteLine(product.ToString());
            }
        }
    }
}
