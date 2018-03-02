using System;
using System.Collections.Generic;

namespace ProductImplementation
{
    public class PaymentTerminal
    {
        private CoinPayment changeMachine = new CoinPayment(9999999, 1);
        private PaymentEvent paymentEvent = new PaymentEvent();

        public PaymentTerminal()
        {

        }
        public PaymentTerminal(Dispenser dispenser)
        {
            paymentEvent.Subscribe(dispenser);
            paymentEvent.Subscribe(DataAcquisition.Instance);
        }

        public (decimal,bool) Pay(int id, Payment payment)
        {
            decimal paid = 0;
            decimal initialPrice = payment.toPay;
            decimal change = 0;
            bool success;
            while (payment.toPay > 0)
            {
                decimal accumulate = payment.Accumulate();
                if(accumulate==-1)
                {
                    break;
                }
                else
                {
                    paid += accumulate;
                }             
            }
            if (payment.IsValid())
            {
                change = changeMachine.GiveChange(paid - initialPrice);
                paymentEvent.Notify(id);
                success = true;
            }
            else
            {
                change = changeMachine.GiveChange(paid);
                success = false;
            }
            return (change,success);
        }
    }

}