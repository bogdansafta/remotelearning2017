using System;

namespace VendingMachine
{
    public interface IPaymentSubscriber
    {
        void Subscribe();
        void Unsubscribe();
    } 
}