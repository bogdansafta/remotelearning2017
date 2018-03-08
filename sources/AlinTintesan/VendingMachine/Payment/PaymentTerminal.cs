using System;

namespace VendingMachine
{
    public class PaymentTerminal
    {
        public Dispenser dispenser { get; private set; }

        public PaymentEvent paymentEvent;

        public double Refund { get; private set; }

        public event EventHandler ProductDispensed;

        protected virtual void onProductDispensed(EventArgs e)
        {
            EventHandler handler=ProductDispensed;
            if(handler!=null)
                handler(this,e);
        }

        public PaymentTerminal(Dispenser dispenser)
        {
            this.dispenser = dispenser;
            this.paymentEvent=new PaymentEvent();
            this.paymentEvent.Subscribe(dispenser);
            this.paymentEvent.Subscribe(dispenser.repository);
        }

        public void Pay(int productID, Payment payment)
        {
            Product productToDispense=this.dispenser.GetProductByID(productID);
            if(productToDispense!=null)
            {
                double price=productToDispense.Price;
                double change=payment.Change(price);
                if(change>=0)
                {
                    onProductDispensed(EventArgs.Empty);
                    this.paymentEvent.Notify(productToDispense);   
                }
                else
                {
                    this.Refund=payment.Refund;
                    throw new NotEnoughMoneyException();
                }  
            } 
            else
            {
                this.Refund=payment.Refund;
                throw new NotEnoughMoneyException();
            }

        }
    }
}