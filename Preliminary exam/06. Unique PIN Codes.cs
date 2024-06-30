using System;

namespace UniquePINCodes {
    class Program {
        static void Main(string[] args) {
            int upperLimitFirstDigit = int.Parse(Console.ReadLine());
            int upperLimitSecondDigit = int.Parse(Console.ReadLine());
            int upperLimitThirdDigit = int.Parse(Console.ReadLine());

            for (int firstDigit = 2; firstDigit <= upperLimitFirstDigit; firstDigit += 2) {
                for (int secondDigit = 2; secondDigit <= upperLimitSecondDigit; secondDigit++) {
                    if (IsPrime(secondDigit)) {
                        for (int thirdDigit = 2; thirdDigit <= upperLimitThirdDigit; thirdDigit += 2) {
                            Console.WriteLine($"{firstDigit} {secondDigit} {thirdDigit}");
                        }
                    }
                }
            }
        }

        static bool IsPrime(int number) {
            if (number < 2) {
                return false;
            }
   
            for (int i = 2; i <= Math.Sqrt(number); i++) {
                if (number % i == 0) {
                    return false;
                }
            }

            return true;
        }
    }
}