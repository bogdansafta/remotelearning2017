using System;
using System.Collections.Generic;

namespace VendingMachine
{
    public class PaymentTerminal
    {
        public PaymentTerminal() { }
        public PaymentTerminal(Dispenser dispenser)
        {
            paymentEvent.Subscribe(dispenser);
        }

        private PaymentEvent paymentEvent = new PaymentEvent();
        public Decimal Credit { get; private set; }

        public Coin GiveChange(Decimal Price)
        {
            Coin coinChange = new Coin();
            coinChange.Value = coinChange.ChangeForPrice(Price);
            Credit = 0;
            return coinChange;
        }

        public void CollectCash(Coin coin, Banknote banknote, Decimal price)
        {
            this.Credit = coin.Value + banknote.Value;
            if(Credit<price)
            {
                GiveChange(0);
                throw (new Exception("Not enough money"));
            }
        }

        public void CollectCreditCard(CreditCard creditCard, int pin, Decimal price)
        {
            if (creditCard.Pin.Equals(pin))
            {
                this.Credit = price;
            }
            else
            {
                throw (new Exception("Wrong Pin"));
            }
        }

        public void Pay(Boolean cardMode,int Id, Decimal price, Coin coin = null, Banknote banknote = null, CreditCard creditCard = null, int pin = 0)
        {
            //CardMode is "false" for cash payment and "true" for card payment
            if (cardMode)
            {
                CollectCreditCard(creditCard, pin, price);
            }
            else
            {
                CollectCash(coin, banknote, price);   
            }
            paymentEvent.Notify(Id);
        }

    }
}