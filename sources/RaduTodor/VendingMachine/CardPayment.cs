using System;

namespace VendingMachine
{
    internal class CardPayment : Payment
    {
        public override bool Change(double price)
        {
            Random random = new Random();
            return (random.Next(1, 3) == 1);
        }
    }
}