
using System;
using System.Collections.Generic;

namespace VendingMachine
{
    public class PaymentTerminal
    {
        private PaymentEvent paymentEvent;
        private Dispenser dispenser;
        private Payment payment;
        private const string invalidInput = "Invalid input";

        public PaymentTerminal()
        {
            paymentEvent = new PaymentEvent();
            dispenser = new Dispenser();
            paymentEvent.Subscribe(dispenser);
        }

        public void Pay(int id, Payment payment)
        {
            this.payment = payment;
            Product product = GetProductById(id);

            if (!(payment is CreditCardPayment))
            {
                AddMoney(product.Price);
            }
            else
            {
            CheckCreditCardValidity:
                if (((CreditCardPayment)payment).IsValid())
                {
                    Console.WriteLine("Card accepted.");
                    payment.AmountPaid += product.Price;
                }
                else
                {
                    Console.WriteLine("Card rejected.");
                    Console.WriteLine("Try again? Y/N");
                    string answer = Console.ReadLine();

                    if (answer.ToLower().Equals("y"))
                    {
                        goto CheckCreditCardValidity;
                    }
                }
            }

            if (payment.AmountPaid == 0)
            {
                return;
            }

            Console.WriteLine("\nProduct ready to be dispensed..");

            try
            {
                paymentEvent.Notify(id);
                Console.WriteLine($"Product at id: {id} ({product.Name}) has been dispensed.");
            }
            catch (ProductNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                paymentEvent.Unsubscribe(dispenser);
            }

            Console.WriteLine(payment.GetChange(product.Price));
        }

        public Payment GetPayment()
        {
            Console.WriteLine("\nPlease select the payment type: 1-Coin, 2-Banknote, 3-Credit card; Or cancel: 4");

            int.TryParse(Console.ReadLine(), out int paymentType);

            switch (paymentType)
            {
                case 1:
                    return new CoinPayment();
                case 2:
                    return new BanknotePayment();
                case 3:
                    return new CreditCardPayment();
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine(invalidInput);
                    return GetPayment();
            }

            return null;
        }

        private Product GetProductById(int id)
        {
            try
            {
                return dispenser.GetProduct(id);
            }
            catch (ProductNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        private void AddMoney(double price)
        {
            Console.WriteLine($"\nSelect a monetary unit out of: [{string.Join(',', payment.AcceptedMonetaryUnits)}]"
                             + " or press 0 to cancel/ get refunded.");
            double.TryParse(Console.ReadLine(), out double amountSelected);

            switch (amountSelected)
            {
                case 10:
                    payment.AmountPaid += 10;
                    break;
                case 5:
                    payment.AmountPaid += 5;
                    break;
                case 1:
                    payment.AmountPaid += 1;
                    break;
                case 0.5:
                    if (payment is BanknotePayment)
                        break;
                    payment.AmountPaid += 0.5;
                    break;
                case 0:
                    Console.WriteLine(((CoinPayment)payment).GetRefund());
                    return;
            }

            Console.WriteLine($"Current amount of money: {payment.AmountPaid}");
            if (payment.AmountPaid < price)
            {
                AddMoney(price);
            }
        }

        private class PaymentEvent : IPaymentNotifier, IPaymentSubscriber
        {
            private List<IPaymentListener> listeners;

            public PaymentEvent()
            {
                listeners = new List<IPaymentListener>();
            }

            public void Notify(int idProduct)
            {
                foreach (IPaymentListener listener in listeners)
                {
                    listener.Update(idProduct);
                }
            }

            public void Subscribe(IPaymentListener listener)
            {
                listeners.Add(listener);
            }

            public void Unsubscribe(IPaymentListener listener)
            {
                if (!listeners.Contains(listener))
                {
                    return;
                }

                listeners.Remove(listener);
            }
        }
    }
}