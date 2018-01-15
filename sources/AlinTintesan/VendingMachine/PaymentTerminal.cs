using System;

namespace VendingMachine
{
    public class PaymentTerminal
    {
        public Dispenser dispenser { get; private set; }

        public PaymentTerminal(Dispenser dispenser)
        {
            this.dispenser = dispenser;
        }

        public bool Pay(int id, Payment payment)
        {
            Product productToDispense=this.dispenser.GetProductByID(id);
            if(productToDispense!=null)
            {
                double price=productToDispense.Price;
                double change=payment.Change(price);
                if(change>=0)
                {
                    this.dispenser.Dispense(id);
                    Console.WriteLine($"Succesfully bought {productToDispense.Name}. Here's your change {change}");
                    return true;    
                }
                else
                {
                    Console.WriteLine($"Not enough money! Refund {payment.Refund}");
                    return false;
                }  
            } 
            else
            {
                Console.WriteLine($"Product unavailable. Refund: {payment.Refund}");
                return false;
            }
        }
    }
}