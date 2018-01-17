using System;
namespace VendingMachine
{
    abstract class Payment
    {        
        public Change(double paid, double price)
        {
            double change = paid - price;
            return change;
        }
    }
}