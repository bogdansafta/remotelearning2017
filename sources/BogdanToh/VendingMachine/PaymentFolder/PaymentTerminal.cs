using System;
using System.Collections.Generic;

namespace VendingMachine {
    public class PaymentTerminal : IPaymentSubscriber {

        private class Subscriber {
            private List<IPaymentNotifer> observers = new List<IPaymentNotifer> ();
            public void Subscribe (IPaymentNotifer observer) {
                observers.Add (observer);
            }

            public void Unsubscribe (IPaymentNotifer observer) {
                observers.Remove (observer);
            }

            public void Notify (int productId) {
                observers.ForEach (observer => observer.update (productId));

            }
        }
        public void Pay (int id, Payment payment) {
            Dispenser dispenser = new Dispenser ();
            Subscriber getNotified = new Subscriber ();
            getNotified.Subscribe (dispenser);
            Product wantedProduct = null;
            try {
                wantedProduct = Dispenser.GetProduct (id);

                double change = 0, accumulate = 0;
                if (payment.GetType ().Equals (new Coin ().GetType ())) {
                    payment = new Coin ();
                }

                if (payment.GetType ().Equals (new Banknote ().GetType ())) {
                    payment = new Banknote ();
                }

                if (payment.GetType ().Equals (new CreditCard ().GetType ())) {
                    payment = new CreditCard ();
                    CreditCardVerification card = new CreditCardVerification ();
                    bool cardIsValid = card.validate ();
                    double moneyOnCard = 1000;
                    change = payment.change (moneyOnCard, wantedProduct.Price);
                    if (cardIsValid && payment.IsValid) {
                        getNotified.Notify (id);
                        Console.WriteLine ($"You have bought {wantedProduct.Name} and your change is {change}");
                    } else Console.WriteLine ("Your card is invalid");

                }
                if (payment.GetType ().Equals (new Coin ().GetType ()) || payment.GetType ().Equals (new Banknote ().GetType ())) {
                    change = payment.change (accumulate, wantedProduct.Price);
                    if (payment.IsValid) {
                        getNotified.Notify (id);
                        Console.WriteLine ($"You have bought {wantedProduct.Name} and your change is {change}");
                    }
                }
            } catch (Exception e) { Console.WriteLine ("PaymentTerminal " + e); }
        }

    }
}