using System;
using System.Collections;

public abstract class IPaymentSubscribe
{
    private ArrayList observers = new ArrayList();
    public void Subscribe(IPaymentNotify observer)
    {
        observers.Add(observer);
    }
    public void Unsubscribe(IPaymentNotify observer)
    {
        observers.Remove(observer);
    }
    public void Notify()
    {
        foreach (IPaymentNotify observer in observers)
        {
            observer.Update(this);
        }
    }
}