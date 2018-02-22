using System;

namespace VendingMachine {
    public class Coin : Payment {
        public override bool IsValid { get; protected set; }
        public override double change (double accumulate, double price) {
            IsValid = false;
            double insertcoins = 0;
            Console.WriteLine ("Insert coins:");
            while (accumulate < price) {
                if (double.TryParse (Console.ReadLine (), out insertcoins)) {
                    if (insertcoins == 1 || insertcoins == 5) {
                        accumulate = accumulate + insertcoins;

                        if (accumulate < price) {
                            Console.WriteLine ("The inserted value is not enough,you still need " + (price - accumulate));
                        }
                    } else Console.WriteLine ("You have to use only 10 or 50 coins");

                    if (accumulate >= price) {
                        IsValid = true;
                        break;
                    }
                } else Console.WriteLine ("Invalid value");
            }
            return accumulate - price;
        }
    }
}