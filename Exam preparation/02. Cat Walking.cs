using System;

namespace CatWalkings {
    class Program {
        static void Main(string[] args) {
            int minutesWalkPerDay = int.Parse(Console.ReadLine());
            int numberOfWalksPerDay = int.Parse(Console.ReadLine());
            int calories = int.Parse(Console.ReadLine());

            int totalBurnCalories = (minutesWalkPerDay * numberOfWalksPerDay) * 5;

            if (totalBurnCalories >= (calories / 2)) {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalBurnCalories}.");
            }
            else {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalBurnCalories}.");
            }
        }
    }
}