using System;
using System.Text;

namespace VendingMachine
{
    public class BanknotePayment : Payment
    {
        public BanknotePayment(double paid)
        {
            this.Paid=paid;
        }
        public override double Change(double price) => this.Paid-price;        

        public override double Refund => this.Paid;

        public String ChangeGiven(double change)
        {
            StringBuilder written = new StringBuilder();
            double[] banknotes = new double[] { 10, 5, 1 };
            double[] coins = new double[] { 0.50F, 0.10F, 0.05F, 0.01F };
            for (int index = 0; index < banknotes.Length; index++)
            {
                while (change >= banknotes[index])
                {
                    written.Append($", {banknotes[index]}");
                    change -= banknotes[index];
                }
            }
            written.Append(" lei ");
            for (int index = 0; index < coins.Length; index++)
            {
                while (change >= coins[index])
                {
                    written.Append($", {coins[index]}");
                    change -= coins[index];
                }
            }
            written.Append(" bani");

            return written.ToString();
        }
    }

}