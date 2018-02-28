using System;

namespace Vending_machine_V2
{
    public interface IPaymentNotifier
    {
        void Notify(int idProduct);
    }
}
