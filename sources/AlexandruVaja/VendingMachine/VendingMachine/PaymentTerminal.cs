using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class PaymentTerminal
    {
        public void Pay(int id, Payment payment)
        {
            Dispencer dispencer = new Dispencer();
            Product product = dispencer.Get(id);
            double change = payment.Change(payment.paid, product.PriceProduct);
            Console.WriteLine(change);
            dispencer.Dispense(id);
        }
    }
}
