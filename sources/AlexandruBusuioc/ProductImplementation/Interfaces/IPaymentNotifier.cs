using System;
namespace ProductImplementation
{
    public interface IPaymentNotifier
    {
        void Notify(int productId);
    }
}