using System;
namespace ProductImplementation
{
    public abstract class Payment
    {
        public abstract int GiveChange(int value);
        public abstract int InsertMoney();
    }
}