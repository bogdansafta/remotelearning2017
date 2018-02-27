using System;
using System.Text;

namespace VendingMachine
{
    internal class BanknotePayment : Payment
    {
        public override bool Change(double price)
        {
            IsValid = false;
            while (Accumulate < price)
            {
                Console.WriteLine("Insert Banknotes");
                double inserted;
                double.TryParse(Console.ReadLine(), out inserted);
                if (inserted == 50 || inserted == 10 || inserted == 5 || inserted == 1)
                    Accumulate = Accumulate + inserted;
                else
                    throw new MyException("Money not accepted");
            }
            Console.WriteLine(ChangeGiven(Accumulate - price));
            Accumulate = 0;
            IsValid = true;
            return IsValid;
        }

        private String ChangeGiven(double change)
       {
           StringBuilder written = new StringBuilder();
           double[] bancnote = new double[] { 10, 5, 1 };
           double[] monede = new double[] { 0.50, 0.10, 0.05, 0.01};
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
    }
}