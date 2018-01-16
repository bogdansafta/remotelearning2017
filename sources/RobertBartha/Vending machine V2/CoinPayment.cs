using System;

namespace Vending_machine_V2
{
    public class CoinPayment : Payment
    {
        public override bool Change(double price)
        {
            float paid = 0;
            while (paid < price)
            {
                Console.WriteLine("Please insert coins");
                int money = int.Parse(Console.ReadLine());
                if (money == 50 || money == 10 || money == 5 || money == 1)
                {
                    paid = paid + money;
                }
                else
                {
                    Console.WriteLine("Wrong type/amount of money");
                }
            }
            Console.WriteLine("Amount of change: {0}", paid - price);
            return true;
        }
    }
}