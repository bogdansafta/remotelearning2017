using System;

namespace VendingMachine
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
                Size = 3,
                Id = 1
            };

            Position position2 = new Position()
            {
                Row = 2,
                Column = 1,
                Size = 4,
                Id = 2
            };

            Product product1 = new Product()
            {
                Category = productCategory1,
                Price = 4.5,
                Quantity = 3,
                Name = "Milka"
            };

            Product product2 = new Product()
            {
                Category = productCategory2,
                Price = 6.3,
                Quantity = 2,
                Name = "Sprite"
            };

            Product product3 = new Product()
            {
                Category = productCategory1,
                Price = 3.1,
                Quantity = 1,
                Name = "Poiana"
            };

            ContainableItem containableItem1 = new ContainableItem()
            {
                Position = position2,
                Product = product1

            };

            ContainableItem containableItem2 = new ContainableItem()
            {
                Position = position1,
                Product = product2

            };

            ContainableItem containableItem3 = new ContainableItem()
            {
                Position = position1,
                Product = product3
            };

            ContainableItemsCollection containableItemsCollection = new ContainableItemsCollection();
            Dispenser dispenser = new Dispenser(containableItemsCollection);

            PaymentTerminal paymentTerminal = new PaymentTerminal(dispenser);

            containableItemsCollection.AddProduct(containableItem1);
            containableItemsCollection.AddProduct(containableItem2);
            containableItemsCollection.AddProduct(containableItem3);

            for (int i = 0; i < containableItemsCollection.Count(); i++)
            {
                Console.WriteLine(containableItemsCollection.GetItem(i));
            }

            Console.WriteLine("Alegeti id-ul produsului");
            int productId = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("1. Plata cu bancnote");
            Console.WriteLine("2. Plata cu monede");
            Console.WriteLine("3. Plata cu cardul");

            int counter = Convert.ToInt32(Console.ReadLine());

            switch (counter)
            {
                case 1:
                    Payment paymentBanknotes = new BanknotePayment();
                    paymentTerminal.Pay(productId, paymentBanknotes);

                    break;

                case 2:
                    Payment paymentCoins = new CoinPayment();
                    paymentTerminal.Pay(productId, paymentCoins);

                    break;

                case 3:
                    Payment paymentCard = new CreditCardPayment();
                    paymentTerminal.Pay(productId, paymentCard);

                    break;

                default:
                    Console.WriteLine("gresit!");
                    break;
            }

            Singleton singleton = Singleton.Instance;
            Console.WriteLine(singleton.ToString());
        }
    }
}