using System;

namespace FinalCompetition {
    class Program {
        static void Main(string[] args) {
            int numberOfDancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string location = Console.ReadLine().ToLower();

            double prizeMoney = 0.0;
            if (location == "bulgaria") {
                prizeMoney = numberOfDancers * points;
            }
            else if (location == "abroad") {
                prizeMoney = numberOfDancers * points * 1.5;
            }

            double expensesPercentage = 0.0;
            if (location == "bulgaria") {
                if (season == "summer") {
                    expensesPercentage = 0.05;
                }
                else if (season == "winter") {
                    expensesPercentage = 0.08;
                }
            }
            else if (location == "abroad") {
                if (season == "summer") {
                    expensesPercentage = 0.10;
                }
                else if (season == "winter") {
                    expensesPercentage = 0.15;
                }
            }

            double finalAmount = prizeMoney * (1 - expensesPercentage);

            double charityAmount = finalAmount * 0.75;
            double moneyPerDancer = (finalAmount - charityAmount) / numberOfDancers;

            Console.WriteLine($"Charity - {charityAmount:F2}");
            Console.WriteLine($"Money per dancer - {moneyPerDancer:F2}");
        }
    }
}
