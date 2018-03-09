using System;
using System.Collections.Generic;

namespace VendingMachine
{
    public class PaymentEvent : IPaymentNotifier, IPaymentSubscriber
    {
        List<IPaymentListener> listeners;
        public PaymentEvent()
        {
            listeners = new List<IPaymentListener>();
        }

        public void Notify(Product product)
        {
            foreach (var listener in listeners)
            {
                listener.Update(product);
            }
        }

        public void Subscribe(IPaymentListener subscriber)
        {
            listeners.Add(subscriber);
        }

        public void Unsubscribe(IPaymentListener unsubscribe)
        {
            listeners.Remove(unsubscribe);
        }
    }
}