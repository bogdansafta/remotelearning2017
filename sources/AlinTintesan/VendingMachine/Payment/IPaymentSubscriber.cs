using System;
using System.Collections.Generic;

namespace VendingMachine
{
    public interface IPaymenySubscriber
    {
        void Subscribe(IPaymentListener subscriber);
        void Unsubscribe(IPaymentListener subscriber);
    }
}