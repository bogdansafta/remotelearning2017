using System;
namespace VendingMachine
{
    public abstract class Payment
    {

        public static Decimal Value {get; set;}
        public static Boolean IsValidForPrice(Decimal Price)
        {
            return (Value - Price >= 0);
        }

        public Decimal ChangeForPrice(Decimal Price)
        {
            Decimal change = Value - Price;
            return change;
        }
    }
}