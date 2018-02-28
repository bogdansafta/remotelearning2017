using System;

namespace Vending_machine_V2
{
    public class PaymentEvent : IPaymentNotifier, IPaymentSubscriber
    {
        List<IPaymentListener> listeners;
        public PaymentEvent()
        {
            listeners = new List<IPaymentListener>();
        }
        public void Notify(int idProduct)
        {
            foreach (var listener in listeners)
            {
                listener.Update();
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