using System;
namespace ProductImplementation
{
    public abstract class Payment
    {
        public decimal toPay;
        public Payment()
        {
            this.toPay = 0;
        }
        public Payment(decimal toPay)
        {
            this.toPay = toPay;
        }
        public abstract decimal Accumulate();
        public abstract bool IsValid();
        public abstract decimal GiveChange(decimal paid);

    }
}