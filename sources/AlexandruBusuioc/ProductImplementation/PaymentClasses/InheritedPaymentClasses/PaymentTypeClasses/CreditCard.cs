using System;
namespace ProductImplementation
{
    public class CreditCard
    {
        private int pin;
        public CreditCard(int pin)
        {
            this.pin = pin;
        }
        public bool Verify()
        {
            System.Console.WriteLine("Confirm your pin for payment:");
            int query = Int32.Parse(Console.ReadLine());
            if (query == pin)
                return true;
            return false;
        }
    }
}