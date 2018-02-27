using System;
using System.Collections.Generic;
using System.Linq;
namespace ProductImplementation
{
    public class CoinPayment : Payment
    {
        private int numberOfCoins;
        private int coinValue;
        private List<Coin> coins;
        public CoinPayment(int numberOfCoins, int coinValue)
        {
            this.numberOfCoins = numberOfCoins;
            this.coinValue = coinValue;
            this.coins = new List<Coin>();
            for (int i = 0; i < numberOfCoins; i++)
            {
                coins.Add(new Coin(coinValue));
            }
        }
        public int CalculateCoins()
        {
            return coins.Count*coinValue;
        }
        public bool Verify(decimal quantityPaid, decimal quantityToPay)
        {
            return (quantityPaid>=quantityToPay);
        }
        public override int GiveChange(int value)
        {
            Console.WriteLine($"Need to return: {value}");
            int remaining = value;
            int count = 0;
            while (remaining > 0)
            {
                if (coinValue > value)
                {
                    break;
                }
                if (coins.Count>=1)
                {
                    remaining -= coinValue;
                    count++;
                    coins.Remove(coins.FirstOrDefault());
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"{count} coins recieved (each coin is : {coinValue})");
            return count;
        }
        public override int InsertMoney()
        {
            if (coins.Count < 1)
            {
                Console.WriteLine("You're out of coins!");
                return 0;
            }
            Console.WriteLine($"Insert a coin ({coinValue}) by pressing any key");
            Console.ReadKey();
            coins.Remove(coins.FirstOrDefault());
            return this.coinValue;
        }
    }
}