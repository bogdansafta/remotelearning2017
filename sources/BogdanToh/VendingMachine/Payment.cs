namespace VendingMachine
{
    public abstract class Payment
    {
       public abstract double change(int paid,double price);
    }
}