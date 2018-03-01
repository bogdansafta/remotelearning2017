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
            int confirmPin = Int32.Parse(Console.ReadLine());
            return (confirmPin == pin);
        }
    }
}