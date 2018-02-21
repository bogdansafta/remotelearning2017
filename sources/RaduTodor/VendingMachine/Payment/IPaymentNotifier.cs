using System;

namespace VendingMachine
{
    interface IPaymentNotifier
    {
        void notify(int productID);
    }
}