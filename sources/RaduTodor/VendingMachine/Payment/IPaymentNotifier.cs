using System;

namespace VendingMachine
{
    interface IPaymentNotifier
    {
        void Notify(int productID);
    }
}