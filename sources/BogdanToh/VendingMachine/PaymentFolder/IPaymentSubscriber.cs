
using System;
using System.Collections.Generic;
namespace VendingMachine
{
    public abstract class IPaymentSubscriber
    {
        /* 
        private List<IPaymentNotifer> observers = new List<IPaymentNotifer>();`
        public void Subscribe(IPaymentNotifer observer)
        {
            observers.Add(observer);
        }
        
        public void Unsubscribe(IPaymentNotifer observer)
        {
            observers.Remove(observer);
        }

        public  void Notify(int productId)
        {
             observers.ForEach(obs=>obs.update(productId));
             
        }
        */
      
    }
}