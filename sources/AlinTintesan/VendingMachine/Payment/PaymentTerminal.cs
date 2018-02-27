using System;

namespace VendingMachine
{
    public class PaymentTerminal
    {
        public Dispenser dispenser { get; private set; }

        public PaymentEvent paymentEvent;
        public PaymentTerminal(Dispenser dispenser)
        {
            this.dispenser = dispenser;
            this.paymentEvent=new PaymentEvent();
            this.paymentEvent.Subscribe(dispenser);
        }

        public bool Pay(int productID, Payment payment)
        {
            Product productToDispense=this.dispenser.GetProductByID(productID);
            if(productToDispense!=null)
            {
                double price=productToDispense.Price;
                double change=payment.Change(price);
                if(change>=0)
                {
                    this.dispenser.Dispense(productID);
                    Console.WriteLine($"Succesfully bought {productToDispense.Name}. Here's your change {change}");
                    this.paymentEvent.Notify(productID);
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