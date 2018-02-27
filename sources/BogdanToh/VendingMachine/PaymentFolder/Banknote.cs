using System;
namespace VendingMachine {
    public class Banknote : Payment {
        public override bool IsValid { get; protected set; }
        public override double change (double accumulate, double price) {
            IsValid = false;
            double insertBanknotes = 0;
            Console.WriteLine ("Insert banknotes:");
            while (accumulate < price) {
                if (double.TryParse (Console.ReadLine (), out insertBanknotes)) {
                    if (insertBanknotes == 100 || insertBanknotes == 50 || insertBanknotes == 10 || insertBanknotes == 5 || insertBanknotes == 1) {
                        accumulate = accumulate + insertBanknotes * 10;

                        if (accumulate < price) {
                            Console.WriteLine ("The inserted value is not enough,you still need " + (price - accumulate));
                        }
                    } else Console.WriteLine ("You have to use only 100ron or 50ron or 10ron or 5ron or 1ron banknotes");

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