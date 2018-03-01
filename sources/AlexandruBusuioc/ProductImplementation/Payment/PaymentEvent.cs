using System;
using System.Collections.Generic;
namespace ProductImplementation
{
    public class PaymentEvent : IPaymentNotifier, IPaymentSubscriber
    {
        private List<IPaymentListener> listeners = new List<IPaymentListener>();
        public void Subscribe(IPaymentListener listener)
        {
            listeners.Add(listener);
        }
        public void Unsubscribe(IPaymentListener listener)
        {
            listeners.Remove(listener);
        }
        public void Notify(int productId)
        {
            foreach (var subscriber in listeners)
            {
                subscriber.Update(productId);
            }
        }
    }
}