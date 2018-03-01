using System;
namespace ProductImplementation
{
    public class BanknotePayment : Payment
    {
        public decimal initialPrice;
        
        public override bool IsValid()
        {
            return true;
        }
        public override decimal Accumulate()
        {
            return 0;
        }

        public override decimal GiveChange(decimal paid)
        {
            return 0;
        }

    }
}