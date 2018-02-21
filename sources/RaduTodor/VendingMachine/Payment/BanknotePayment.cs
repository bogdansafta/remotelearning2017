using System;

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
            String written = "";
            while (change >= 10)
            {
                written += ", 10";
                change -= 10;
            }
            while (change >= 5)
            {
                written += ", 5";
                change -= 5;
            }
            while (change >= 1)
            {
                written += ", 1";
                change -= 1;
            }
            written += " lei ";
            if (change != 0)
            {
                while (change >= 0.50)
                {
                    written += ", 50";
                    change -= 0.50;
                }
                while (change >= 10)
                {
                    written += ", 10";
                    change -= 0.10;
                }
                while (change >= 5)
                {
                    written += ", 5";
                    change -= 0.05;
                }
                while (change >= 1)
                {
                    written += ", 1";
                    change -= 0.01;
                }
                written += " bani";
            }
            return written;
        }
    }
}