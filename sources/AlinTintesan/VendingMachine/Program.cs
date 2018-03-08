using System;
using System.Collections.Generic;

#pragma warning disable 0168

namespace VendingMachine
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            List<Position> positions = new List<Position>();
            List<ProductCategory> categories = new List<ProductCategory>();
            ContainableItemsCollection collection = new ContainableItemsCollection();
            VendingMachineSetup(positions, categories, collection);
            Dispenser dispenser = new Dispenser(collection);
            PaymentTerminal paymentTerminal=new PaymentTerminal(dispenser);
            paymentTerminal.ProductDispensed+=ProductDispensed;
            MainMenu(paymentTerminal);
            dispenser.Report();
        }

        public static void MainMenu(PaymentTerminal terminal)
        {
            bool isRunning=true;
            while(isRunning)
            {
                System.Console.WriteLine("Welcome to our VendingMachine!");
                System.Console.WriteLine("Please select an option:");
                System.Console.WriteLine("1) Make a purchase");
                System.Console.WriteLine("2) Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    default: 
                    System.Console.WriteLine("Invalid option, try again!");
                    break;

                    case 1:
                    MakeAPurchase(terminal);
                    break;

                    case 2:
                    isRunning=false;
                    break;
                }
            }
        }

        public static void MakeAPurchase(PaymentTerminal terminal)
        {
            System.Console.WriteLine("Please select the ID of the desired product from the list below:");
            for(int index=0; index<terminal.dispenser.containableItemsCollection.Count(); index++)
                System.Console.WriteLine($"ID: {terminal.dispenser.containableItemsCollection.Get(index).Position.ID} -> {terminal.dispenser.containableItemsCollection.Get(index).Product.ToString()}");
            System.Console.WriteLine("Your option: ");
            int option=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Choose payment method:");
            System.Console.WriteLine("1) Banknotes");
            System.Console.WriteLine("2) Coins");
            System.Console.WriteLine("3) Credit Card");
            int paymentOption=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Please insert money!");
            int moneyInserted=Convert.ToInt32(Console.ReadLine());
            Payment payment=null;

            switch(paymentOption)
            {
                default:
                System.Console.WriteLine("Invalid option!");
                break;

                case 1:
                payment=new BanknotePayment(moneyInserted);
                break;

                case 2:
                payment=new CoinPayment(moneyInserted);
                break;
                
                case 3:
                payment=new CreditCardPayment(moneyInserted);
                break;
            }

            try
            {
                terminal.Pay(option, payment);
                System.Console.WriteLine($"{terminal.dispenser.dispensedProduct.ToString()}");
            }
            catch(VendingMachine.CreditCardRejectedException e)
            {
                System.Console.WriteLine("Credit card rejected!");
            }
            catch(VendingMachine.NotEnoughMoneyException e)
            {
                System.Console.WriteLine($"Not enough money! Refund: {terminal.Refund}");
            }
            catch(VendingMachine.ProductUnavailableException e)
            {
                System.Console.WriteLine("Product unavailable!");
            }
        }

        public static void ProductDispensed(object sender, EventArgs e)
        {
            Console.WriteLine("Product dispensed succesfully! -- event");
        }

        public static void VendingMachineSetup(List<Position> positions, List<ProductCategory> categories, ContainableItemsCollection collection)
        {
            positions.Add(new Position(1,1,1,1));
            positions.Add(new Position(1,2,2,2));
            positions.Add(new Position(1,3,1,3));

            categories.Add(new ProductCategory("Snacks"));
            categories.Add(new ProductCategory("Sodas"));
            categories.Add(new ProductCategory("Sweets"));

            collection.Add(new ContainableItem(positions[0],new Product(positions[0],"Lays",5,2.5,categories[0])));
            collection.Add(new ContainableItem(positions[1],new Product(positions[1],"Cola",1,3,categories[1])));
            collection.Add(new ContainableItem(positions[2],new Product(positions[2],"Snickers",0,2.2,categories[2])));
        }
    }
}
