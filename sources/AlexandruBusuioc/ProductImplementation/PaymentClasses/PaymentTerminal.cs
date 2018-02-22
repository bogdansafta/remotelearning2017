using System;
using System.Collections.Generic;

namespace ProductImplementation
{
    public class PaymentTerminal : IPaymentSubscriber
    {
        private List<IPaymentListener> dispensers = new List<IPaymentListener>();
        private CoinPayment changeMachine = new CoinPayment(9999999,1);
        PaymentEvent paymentEvent;
        public void Subscribe(IPaymentListener dispenser)
        {
            dispensers.Add(dispenser);
        }
        public void Unsubscribe(IPaymentListener dispenser)
        {
            dispensers.Remove(dispenser);
        }

        public void Pay(int id, Payment payment, decimal amountToPay)
        {
            CoinPayment coinPayment = (CoinPayment)payment;
            System.Console.WriteLine($"Need to pay: {amountToPay}");
            decimal amountPaid = 0;
            while (amountPaid < amountToPay)
            {
                System.Console.WriteLine($"Inserted:{amountPaid}, still need to insert {amountToPay-amountPaid}");
                amountPaid += coinPayment.InsertMoney();
                if (coinPayment.Verify(amountPaid, amountToPay))
                {
                    if(amountToPay>0.99m && amountPaid>=amountToPay)
                    {
                        changeMachine.GiveChange((int)(amountPaid-amountToPay));
                    }
                    paymentEvent = new PaymentEvent(dispensers);
                    paymentEvent.Notify(id);
                    break;
                }
            }
            
        }
        public void Pay(int id, Payment payment)
        {
            CreditCardPayment creditCardPayment = (CreditCardPayment)payment;
            if(creditCardPayment.Verify())
            {
                paymentEvent = new PaymentEvent(dispensers);
                paymentEvent.Notify(id);
            }
            else
            {
                System.Console.WriteLine("Payment failed!");
            }
        }

        private class PaymentEvent : IPaymentNotifier
        {
            public List<IPaymentListener> listeners;
            public PaymentEvent(List<IPaymentListener> listeners)
            {
                this.listeners = listeners;
            }
            public void Notify(int productId)
            {
                foreach (var subscriber in listeners)
                {
                    subscriber.Notify(productId);
                }
            }
        }
    }

}