using System;

namespace VendingMachine
{
    public interface IPaymentNotifier
    {
        void Notify(int productID);
    }
}