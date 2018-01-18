
using System;

namespace VendingMachine
{
    public class PaymentTerminal
    {
        private Dispenser dispenser;
        private const string invalidInput = "Invalid input";
        public PaymentTerminal()
        {
            dispenser = new Dispenser();
        }

        public void Pay(int id, Payment payment)
        {
            double change;

        AddMoney:
            Console.WriteLine("Enter amount of money:");
            string s = Console.ReadLine();
            if (!double.TryParse(s, out double amountPaid))
            {
                Console.WriteLine(invalidInput);
                goto AddMoney;
            }

            payment.AmountPaid += amountPaid;

            Product product = new Product();
            try
            {
                product = dispenser.GetProduct(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            
            if (payment.AmountPaid < product.Price)
            {
                Console.WriteLine("Product price is higher than the amount paid.");
            LowPriceChoice:
                Console.WriteLine("1 - add more money, 2- refund");

                if (!int.TryParse(Console.ReadLine(), out int lowPriceChoice))
                {
                    Console.WriteLine(invalidInput);
                    goto LowPriceChoice;
                }
                switch (lowPriceChoice)
                {
                    case 1:
                        goto AddMoney;
                    case 2:
                        change = payment.GetChange(payment.AmountPaid, 0);
                        Console.WriteLine($"Change: {change}");
                        break;
                    default:
                        break;
                }
            }

            change = payment.GetChange(payment.AmountPaid, product.Price);
            Console.WriteLine($"Change: {change}");
            dispenser.Dispense(id);
            Console.WriteLine($"Product at id: {id}: {product.Name} was dispensed.");
        }
    }
}