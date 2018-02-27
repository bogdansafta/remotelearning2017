namespace VendingMachine
{
    public interface IPaymentNotifier
    {
        void Notify(int idProduct);
    }
}