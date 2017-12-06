using System;
using System.Linq;

namespace VendingMachine
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
            MyList<Product> products = new MyList<Product>();
            Product coffeeProduct = new Product()
            {
                Category = Category.Beverages,
                Name = "Coffee",
                Price = 5
            };

            products.Add(coffeeProduct);

            products.AddRange(
                new Product
                {
                    Category = Category.Beverages,
                    Name = "Cola",
                    Price = 12.5
                },
                new Product
                {
                    Category = Category.Snacks,
                    Name = "Chips",
                    Price = 10.5
                }
            );

            if(products.Contains(coffeeProduct)){
                products.Remove(coffeeProduct);
            }

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
                new Product{
                    Category = Category.Beverages,
                    Name = "Cola",
                    Price = 12.5
            });
            productCollection.Add(
                new Product{
                    Category = Category.Snacks,
                    Name = "Chips",
                    Price = 10.5
            });

            Product beverageProduct = productCollection.FirstOrDefault(product=>product.Category==Category.Beverages);
            Console.WriteLine("\nExample using product Collection:\n");
            
            Console.WriteLine($"Beverage:\t{beverageProduct?.ToString()}");
            Console.WriteLine($"Last product:\t{productCollection.GetItem(productCollection.Count-1)}");
            Console.WriteLine("\nProducts in productCollection:");
            foreach (Product product in productCollection)
            {
                Console.WriteLine(product.ToString());
            }
        }
    }
}
