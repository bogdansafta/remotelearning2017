using System;

namespace VendingMachine
{
    public interface IPaymentSubscriber
    {
        void Subscribe(IPaymentListener subscriber);
        void Unsubscribe(IPaymentListener unsubscribe);
    }
}