using System;

namespace Vending_machine_V2
{
    public class BanknotePayment : Payment
    {
        float paid = 0;
        public override bool Change(double price)
        {

            while (paid < price)
            {
                Console.WriteLine("Please insert banknotes");
                int money = int.Parse(Console.ReadLine());
                if (money == 500 || money == 200 || money == 100
                || money == 50 || money == 10 || money == 5 || money == 1)
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
        public override bool IsValid(Product product)
        {
            if (product.price == paid)
                return true;
            return false;
        }
    }
}