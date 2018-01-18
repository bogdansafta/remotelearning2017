using System;

namespace VendingMachine
{
    public class PaymentTerminal
    {
        private Dispenser dispenser;

        public PaymentTerminal(Dispenser dispenser)
        {
            this.dispenser = dispenser;
        }

        public void Pay(int id, Payment payment, double paid)
        {
            Product product = dispenser.Dispense(id);

            if (product != null)
            {
                double change = payment.Change(paid, product.Price);

                if (change >= 0)
                {
                    dispenser.Dispense(id);
                    Console.WriteLine($"Product -> {product}");
                }
                else
                    Console.WriteLine("Don't!");
            }
            else
                Console.WriteLine("Product doesn't exist!");
        }
    }
}