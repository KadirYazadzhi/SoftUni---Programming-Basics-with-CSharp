using System;

namespace CatDiet {
    class Program {
        static void Main(string[] args) {
            int fatPercentage = int.Parse(Console.ReadLine());
            int proteinPercentage = int.Parse(Console.ReadLine());
            int carbPercentage = int.Parse(Console.ReadLine());
            int totalCalories = int.Parse(Console.ReadLine());
            int waterPercentage = int.Parse(Console.ReadLine());

            double fatGrams = (fatPercentage / 100.0) * totalCalories / 9;
            double proteinGrams = (proteinPercentage / 100.0) * totalCalories / 4;
            double carbGrams = (carbPercentage / 100.0) * totalCalories / 4;

            double totalWeight = fatGrams + proteinGrams + carbGrams;

            double caloriesPerGram = totalCalories / totalWeight;

            double nonWaterCaloriesPerGram = caloriesPerGram * ((100 - waterPercentage) / 100.0);

            Console.WriteLine($"{nonWaterCaloriesPerGram:F4}");
        }
    }
}
