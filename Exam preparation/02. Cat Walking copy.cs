using System;

namespace CatWalkings {
    class Program {
        static void Main(string[] args) {
            string drinkType = Console.ReadLine();
            string type = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            
            bool isValid = false;
            double sum = 0;
            if (drinkType == "Espresso") {
                if (type == "Without") {
                    isValid = true;
                    sum = 0.9;
                }
                else if (type == "Normal") {
                    sum = 1.00;
                }
                else if (type == "Extra") {
                    sum = 1.20;
                }
            }
            else if (drinkType == "Cappuccino") {
                if (type == "Without") {
                    isValid = true;
                    sum = 1.00;
                }
                else if (type == "Normal") {
                    sum = 1.20;
                }
                else if (type == "Extra") {
                    sum = 1.60;
                }
            }
            else if (drinkType == "Tea") {
                if (type == "Without") {
                    isValid = true;
                    sum = 0.50;
                }
                else if (type == "Normal") {
                    sum = 0.60;
                }
                else if (type == "Extra") {
                    sum = 0.70;
                }
            }

            sum *= count;

            if (isValid) {
                sum *= 0.65;
            }

            if (drinkType == "Espresso" && count > 5) {
                sum *= 0.75;
            }
            
            if (sum > 15) {
                sum *= 0.8;
            }

            Console.WriteLine($"You bought {count} cups of {drinkType} for {sum:F2} lv.");

        }
    }
}