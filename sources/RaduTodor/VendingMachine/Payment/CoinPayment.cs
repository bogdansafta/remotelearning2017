using System;
using System.Text;

namespace VendingMachine
{
    public class CoinPayment : Payment
    {
        public override Boolean Change(double price)
        {
            IsValid = false;
            while (Accumulate < price)
            {
                Console.WriteLine("Insert Coins");
                double inserted;
                double.TryParse(Console.ReadLine(), out inserted);
                if (inserted == 50 || inserted == 10 || inserted == 5 || inserted == 1)
                {
                    Accumulate = Accumulate + inserted / 100.0;
                }
                else
                {
                    throw new MyException("Money not accepted");
                }
            }
            Console.WriteLine(ChangeGiven(Accumulate - price));
            IsValid = true;
            Accumulate = 0;
            return IsValid;
        }

        private String ChangeGiven(double change)
        {
           StringBuilder written = new StringBuilder();
           double[] monede = new double[] { 0.50, 0.10, 0.05, 0.01};
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
    }
}