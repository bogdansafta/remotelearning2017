using System;
namespace ProductImplementation
{
    public interface IPaymentListener
    {
        void Update(int productId);
    }
}