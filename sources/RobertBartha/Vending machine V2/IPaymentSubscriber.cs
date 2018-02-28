using System;

namespace Vending_machine_V2
{
    public interface IPaymentSubscriber
    {
        void Subscribe(IPaymentListener subscriber);
        void Unsubscribe(IPaymentListener unsubscribe);
    }
}