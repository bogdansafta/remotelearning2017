using System;

namespace VendingMachine
{
    class PaymentTerminal 
    {
        Coin Coin{ get; set; }
        Banknote Banknote{ get; set; }
        CrediCard CrediCard{ get; set; }
        double Credit { get; private set; }

        public void CollectTheMoney(Coin Coin; Banknote Banknote; CreditCard CrediCard)
        {
            this.Credit = Coin.Value + Banknote.Value;
            if (Credit == null)
            {
                this.Credit = CreditCard.Value;
            }
        }

        public Coin giveChange(double paid, double price)
        {
            Coin change;
            change.Value = change.Change(paid, price);
            return change;
        }
    }
}