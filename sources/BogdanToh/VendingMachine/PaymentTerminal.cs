using System;
namespace VendingMachine {
    public class PaymentTerminal {
        private void PayWithCoins (int id, Payment payment) {
            int paid = 0,insertcoins;
            Console.WriteLine ("Insert coins:");
            Product wanted = Dispenser.Dispense (id);
            while (paid < wanted.Price) 
            {
                if (Int32.TryParse (Console.ReadLine (), out insertcoins)) 
                {
                    if (insertcoins % 10 == 0) 
                    {
                        paid = paid + insertcoins;
                    } 
                    else Console.WriteLine ("You have to use only 10,20,30,40,50 coins");

                    if (paid > wanted.Price) 
                    {
                        break;
                    }
                    Console.WriteLine ("The inserted value is not enough");
                    
                } 
                else Console.WriteLine ("Invalid value");
            }
            double change =payment.change(paid,wanted.Price);
            Console.WriteLine(String.Format("Your change is {0}",change));
            Console.WriteLine(String.Format("You have bought {0}",wanted.Name));
        }


        private void PayWithBanknote(int id,Payment payment)
        {
            int paid=0,insertBanknotes;
            Product wanted = Dispenser.Dispense(id);
            Console.WriteLine("Insert banknotes:");

            while (paid < wanted.Price) 
            {
                if (Int32.TryParse (Console.ReadLine (), out insertBanknotes)) 
                {
                    paid = paid + insertBanknotes;
                    if (paid > wanted.Price) 
                    {
                        break;
                    }
                } 
                else Console.WriteLine ("Invalid value");
            }
            double change =payment.change(paid,wanted.Price);
            Console.WriteLine(String.Format("Your change is {0}",change));
            Console.WriteLine(String.Format("You have bought {0}",wanted.Name));
        }

        private void PayWithCreditcard(int id,Payment payment)
        {   
            Console.WriteLine("Cooming soon");
        }
        public void Pay (int id, Payment payment) {
            if (payment.GetType ().Equals (new Coin().GetType ())) 
            {
                PayWithCoins(id,payment);
            }

            if (payment.GetType ().Equals (new Banknote().GetType ())) 
            {
                PayWithBanknote(id,payment);
            }

            if (payment.GetType ().Equals (new CreditCard().GetType ())) 
            {
                PayWithCreditcard(id,payment);
            }
    }
}
}