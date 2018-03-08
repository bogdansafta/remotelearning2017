using System;

namespace VendingMachine
{
    public interface IPaymentNotifier
    {
        void Notify(Product product);
    }
}