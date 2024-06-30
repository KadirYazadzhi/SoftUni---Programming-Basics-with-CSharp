using System;

namespace MovieCenter {
    class Program {
        static void Main(string[] args) {
            double budget = double.Parse(Console.ReadLine());
            string input;

            while ((input = Console.ReadLine()) != "ACTION") {
                string actorName = input;

                if (actorName.Length > 15) {
                    double actorFee = budget * 0.20;
                    budget -= actorFee;
                } else {
                    double actorFee = double.Parse(Console.ReadLine());
                    budget -= actorFee;
                }

                if (budget < 0) {
                    Console.WriteLine($"We need {Math.Abs(budget):F2} leva for our actors.");
                    return;
                }
            }

            Console.WriteLine($"We are left with {budget:F2} leva.");
        }
    }
}
