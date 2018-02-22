using System;
namespace ProductImplementation
{
    public interface IPaymentSubscriber
    {
        void Subscribe(IPaymentListener listener);
        void Unsubscribe(IPaymentListener listener);
    }
}