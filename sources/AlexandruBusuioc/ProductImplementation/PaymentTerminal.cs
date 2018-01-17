using System;
namespace ProductImplementation
{
    public class PaymentTerminal
    {
        private Dispenser dispenser;
        private int numberOfCoins;
        private int coinValue;
        private int moneyInserted;

        private CoinPayment changeDispenser;

        public PaymentTerminal(Dispenser dispenser, int numberOfCoins, int coinValue)
        {
            this.dispenser = dispenser;
            this.numberOfCoins = numberOfCoins;
            this.coinValue = coinValue;
            this.changeDispenser = new CoinPayment(this.numberOfCoins,this.coinValue);
            this.moneyInserted = 0;
        }

        public void Insert(int value)
        {
            moneyInserted += value;
        }

        public void Pay(int id, Payment payment)
        {
            Product product = dispenser.GetProduct(id);
            int change = this.changeDispenser.CalculateCoins();
            while (moneyInserted < (int)product.Price)
            {
                Console.WriteLine($"Money inserted:{moneyInserted}");
                Console.WriteLine($"Still have to pay:{((int)product.Price-moneyInserted)}");
                int paying = payment.InsertMoney();
                if (paying == 0)
                {
                    this.changeDispenser.GiveChange(moneyInserted);
                    return;
                }
                else
                {
                    Insert(paying);
                    Console.WriteLine($"Inserted: {paying}");
                }
            }
            if(change<(moneyInserted - (int)product.Price))
            {
                Console.WriteLine("Not enough change in machine... returning money");
                payment.GiveChange(moneyInserted);
                return;
            }
            this.changeDispenser.GiveChange(moneyInserted-(int)product.Price);
            dispenser.Dispense(id);
        }


    }
}