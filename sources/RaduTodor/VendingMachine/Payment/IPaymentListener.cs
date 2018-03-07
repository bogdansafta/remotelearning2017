using System;

namespace VendingMachine
{
    public interface IPaymentListener
    {
        void Update(int iD);
    }
}