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
            Product product = dispenser.DispenseProduct(productId);

            if (product != null)
            {
                double change = payment.Change(product.Price);

                if (payment.IsValid)
                {
                    dispenser.Dispense(productId);
                    Console.WriteLine($"Product -> {product}");

                    eventPayment.Notify(product);
                }
                else
                    Console.WriteLine("Error! Please try again.");
            }
            else
                Console.WriteLine("Product doesn't exist!");
        }
    }
}