using System;
using System.Collections.Generic;

namespace VendingMachine
{
    class PaymentTerminal : IPaymentSubscriber
    {
        private List<IPaymentListener> paymentListeners = new List<IPaymentListener>();
        public Coin Coin{ get; set; }
        public Banknote Banknote{ get; set; }
        public CreditCard CrediCard{ get; set; }
        public Decimal Credit { get; private set; }

        public void CollectTheMoney(Coin Coin, Banknote Banknote, CreditCard CreditCard)
        {
            this.Credit = Coin.Value + Banknote.Value;
            if (Credit == 0)
            {
                this.Credit = CreditCard.Value;
            }
        }

        public Coin GiveChange(Decimal price)
        {
            Coin change = new Coin();
            change.Value = change.Change(price);
            Credit = 0;
            return change;
        }

        public void Subscribe(IPaymentListener listener)
        {
            paymentListeners.Add(listener);
        }

        public void Unsubscribe(IPaymentListener listener)
        {
            paymentListeners.Remove(listener);
        }

        private class PaymentEvent : IPaymentNotifier
        {
            private IPaymentListener[] listeners;
            public PaymentEvent(IPaymentListener[] thoseListeners)
            {
                listeners = thoseListeners;
            }

            public void Notify(int Id)
            {
                for(int index = 0; index < listeners.Length; index++)
                {
                    listeners[index].Update(Id);
                }
            }
        }
    
    }
}