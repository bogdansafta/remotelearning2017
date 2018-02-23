using System;

namespace VendingMachine
{
    public class PaymentTerminal
    {
        private Dispenser dispenser;
        private PaymentEvent eventPayment;

        public PaymentTerminal(Dispenser dispenser)
        {
            this.dispenser = dispenser;
            eventPayment = new PaymentEvent();
            eventPayment.Subscribe(dispenser);
        }

        public void Pay(int productId, Payment payment)
        {
            Product product = dispenser.Dispense(productId);

            if (product != null)
            {
                double change = payment.Change(product.Price);

                if (change >= 0)
                {
                    dispenser.Dispense(productId);
                    Console.WriteLine($"Product -> {product}");

                    eventPayment.Notify(productId);
                }
                else
                    Console.WriteLine("Don't!");
            }
            else
                Console.WriteLine("Product doesn't exist!");
        }
    }
}