using System;

namespace VendingMachine
{
    internal class PaymentTerminal
    {
        private Dispenser dispenser;
        private Payment payment;

        private PaymentEvent paymentEvent;
        private Data data;

        public PaymentTerminal(Dispenser dispenser)
        {
            this.dispenser = dispenser;
            paymentEvent = new PaymentEvent();
            paymentEvent.Subscribe(dispenser);
            data = Data.Instance;
            paymentEvent.Subscribe(data);
            data.Collection = dispenser.Collection;
        }

        public void Pay(int productId, int option)
        {
            Product product = dispenser.GetProductViaID(productId);
            if (option == 1)
            {
                payment = new CoinPayment();
            }
            else if (option == 2)
            {
                payment = new BanknotePayment();
            }
            else if (option == 3)
            {
                payment = new CardPayment();
            }
            else
            {
                throw new MyException("1,2 or 3...so simple and yet so complicated");
            }
            if (payment.Change(product.Price))
            {
                if (payment.IsValid)
                {
                    paymentEvent.Notify(productId);
                }
            }
        }
    }
}