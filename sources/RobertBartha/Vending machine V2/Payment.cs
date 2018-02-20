using System;

namespace Vending_machine_V2
{
    public abstract class Payment
    {
        public abstract Boolean Change(double price);
        public abstract Boolean IsValid(Product product);
    }
}