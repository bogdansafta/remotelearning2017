namespace VendingMachine
{
    public abstract class Payment
    {
       public abstract double change(double accumulate,double price);
       public abstract bool IsValid{get;protected set;}
       
    }
}