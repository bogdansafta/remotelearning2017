using System;
using System.Text;

namespace Vending_machine_V2
{
    public class CoinPayment : Payment
    {
        float paid = 0;
        public override bool Change(double price)
        {
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
        private String ChangeGiven(double change)
        {
            StringBuilder written = new StringBuilder();
            double[] bancnote = new double[] { 10, 5, 1 };
            double[] monede = new double[] { 0.50F, 0.10F, 0.05F, 0.01F };
            for (int index = 0; index < bancnote.Length; index++)
            {
                while (change >= bancnote[index])
                {
                    written.Append($", {bancnote[index]}");
                    change -= bancnote[index];
                }
            }
            written.Append(" lei ");
            for (int index = 0; index < monede.Length; index++)
            {
                while (change >= monede[index])
                {
                    written.Append($", {monede[index]}");
                    change -= monede[index];
                }
            }
            written.Append(" bani");

            return written.ToString();
        }
        public override bool IsValid(Product product)
        {
            if (product.price == paid)
                return true;
            return false;
        }
    }
}