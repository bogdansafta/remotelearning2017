using System;
using System.Collections.Generic;

namespace VendingMachine
{
    public class PaymentEvent : IPaymentNotifier, IPaymenySubscriber
    {
        public List<IPaymentListener> listeners;

        public PaymentEvent()
        {
            this.listeners=new List<IPaymentListener>();
        }
        
        public void Notify(Product product)
        {
            foreach(var listener in this.listeners)
                listener.Update(product);
        }

        public void Subscribe(IPaymentListener subscriber)
        {
            listeners.Add(subscriber);
        }

        public void Unsubscribe(IPaymentListener subscriber)
        {
            listeners.Remove(subscriber);
        }
    }
}