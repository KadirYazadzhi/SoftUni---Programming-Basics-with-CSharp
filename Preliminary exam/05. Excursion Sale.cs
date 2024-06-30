using System;

namespace ExcursionSale {
    class Program {
        static void Main(string[] args) {
            // Вход
            int seaExcursions = int.Parse(Console.ReadLine());
            int mountainExcursions = int.Parse(Console.ReadLine());
            
            int seaPrice = 680;
            int mountainPrice = 499;
            int profit = 0;

            while (true) {
                string input = Console.ReadLine();

                if (input == "Stop") {
                    break;
                }

                if (input == "sea" && seaExcursions > 0) {
                    profit += seaPrice;
                    seaExcursions--;
                }
                else if (input == "mountain" && mountainExcursions > 0) {
                    profit += mountainPrice;
                    mountainExcursions--;
                }

                if (seaExcursions == 0 && mountainExcursions == 0) {
                    Console.WriteLine("Good job! Everything is sold.");
                    break;
                }
            }

            Console.WriteLine($"Profit: {profit} leva.");
        }
    }
}