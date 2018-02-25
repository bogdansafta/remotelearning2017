using System;
using System.Collections.Generic;

namespace VendingMachine
{
    class PaymentTerminal 
    {
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
    
        class PaymentEvent
        {
           List<IPaymentListener> Listeners = new List<IPaymentListener>();

           
        }
    
    }
}