using System;
namespace ProductImplementation
{
    public interface IPaymentListener
    {
        void Notify(int productId);
    }
}