using System;
namespace VendingMachine {
    public class CreditCardVerification : CreditCard {

        private int[] OddNumbers (string cardNumber) {
            int[] oddNumbers = new int[cardNumber.Length / 2 + 1];
            int j = 0;
            for (int i = 1; i <= CardNumber.Length - 1; i += 2) {
                oddNumbers[j++] = Convert.ToInt32 (CardNumber[i] + "");
            }
            return oddNumbers;
        }

        private int[] EvenNumbers (string cardNumber) {
            int[] evenNumbers = new int[cardNumber.Length / 2 + 1];
            int j = 0;
            for (int i = CardNumber.Length - 2; i >= 0; i -= 2) {
                evenNumbers[j++] = Convert.ToInt32 (CardNumber[i] + "");
            }
            for (int i = 0; i < evenNumbers.Length - 1; i++) {
                evenNumbers[i] = evenNumbers[i] * 2;
                evenNumbers[i] = evenNumbers[i] / 10 + evenNumbers[i] % 10;
            }
            return evenNumbers;
        }

        public bool validate () {
            CardNumber = CardNumberValue (16);
            int[] evenNumbers = EvenNumbers(CardNumber);
            int[] oddNumbers =  OddNumbers(CardNumber);
            int sum = 0;
            for (int i = 0; i < CardNumber.Length/2 - 1; i++) {
                sum += oddNumbers[i] + evenNumbers[i];
            }
            Console.WriteLine("sum is: "+ sum);
            if (sum % 10 != 0) {
                return false;
            }
            return true;
        }

    }
}