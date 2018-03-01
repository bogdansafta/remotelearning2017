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
        public decimal initialPrice;
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
        public CoinPayment(decimal toPay, int numberOfCoins, int coinValue) : base(toPay)
        {
            this.numberOfCoins = numberOfCoins;
            this.coinValue = coinValue;
            this.coins = new List<Coin>();
            for (int i = 0; i < numberOfCoins; i++)
            {
                coins.Add(new Coin(coinValue));
            }
            initialPrice = toPay;
        }
        public override bool IsValid()
        {
            return (toPay<=0);
        }
        public override decimal GiveChange(decimal change)
        {
            decimal returnChange = 0;
            while(change>0)
            {
                if(coins.Count>0)
                {   
                    change -= coins.FirstOrDefault().value;
                    returnChange += coins.FirstOrDefault().value;
                    coins.Remove(coins.FirstOrDefault());
                }
            }
            return returnChange;
        }
        public override decimal Accumulate()
        {
            if (coins.Count < 1)
            {
                return -1;
            }
            decimal value = (decimal)coins.FirstOrDefault().value;
            toPay-=value;
            coins.Remove(coins.FirstOrDefault());
            return value;
        }
    }
}