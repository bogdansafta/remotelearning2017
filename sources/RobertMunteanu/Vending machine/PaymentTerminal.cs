using System;

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

        public Coin giveChange(Decimal paid, Decimal price)
        {
            Coin change = new Coin();
            change.Value = change.Change(paid, price);
            return change;
        }
    }
}