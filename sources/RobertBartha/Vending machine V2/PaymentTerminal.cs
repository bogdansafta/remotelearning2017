using System;

namespace Vending_machine_V2
{
    public class PaymentTerminal
    {
        private Dispenser dispenser;
        public Payment payment;
        private PaymentEvent evPayment;
        public PaymentTerminal(Dispenser dispenser, Payment payment)
        {
            this.dispenser = dispenser;
            this.payment = payment;
            evPayment = new PaymentEvent();
            evPayment.Subscribe(dispenser);
        }
        public void Pay(int id)
        {
            Product product = dispenser.DispenseProduct(id);
            Console.WriteLine("Select payment option : 1-Banknote  2-Coins  3-CreditCard");
            int option = Console.Read();
            if (option == 1)
            {
                payment = new BanknotePayment();
            }
            else if (option == 2)
            {
                payment = new CoinPayment();
            }
            else if (option == 3)
            {
                payment = new CreditCardPayment();
            }
            else
            {
                Console.WriteLine("Choose an available option");
            }
            if (payment.Change(product.price))
            {
                dispenser.DispenseProduct(id);
                evPayment.Notify(id);
            }
        }
    }
}