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

        public void Notify(int productID)
        {
            listeners.ForEach(x => x.Update(productID));
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