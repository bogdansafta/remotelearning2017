using System;
using System.Collections.Generic;

namespace VendingMachine
{
    interface IPaymentSubscriber
    {
        void Subscribe(IPaymentListener subscriber);
        void Unsubscribe(IPaymentListener subscriber);

    }
}