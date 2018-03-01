using System.Collections.Generic;

namespace VendingMachine
{
    public class PaymentEvent : IPaymentSubscriber, IPaymentNotifier
    {
        private List<IPaymentListener> paymentListeners = new List<IPaymentListener>();

        public void Subscribe(IPaymentListener listeners)
        {
            paymentListeners.Add(listeners);
        }

        public void Unsubscribe(IPaymentListener listeners)
        {
            paymentListeners.Remove(listeners);
        }
        public void Notify(int Id)
        {
            foreach (var Listener in paymentListeners)
            {
                Listener.Update(Id);
            }
        }
    }
}