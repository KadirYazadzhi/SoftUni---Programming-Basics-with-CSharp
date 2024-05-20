using System;

public class FruitShop {
    public static void Main(string[] args) {
        string product = Console.ReadLine();
        string day = Console.ReadLine();
        double count = double.Parse(Console.ReadLine());
        
        double sum;
        
        if (day == "Saturday" || day == "Sunday") {
            if (product == "banana") {
                sum = 2.70 * count;
                Console.WriteLine($"{sum:f2}");
            }
            else if (product == "apple") {
                sum = 1.25 * count;
                Console.WriteLine($"{sum:f2}");
            }
            else if (product == "orange") {
                sum = 0.90 * count;
                Console.WriteLine($"{sum:f2}");
            }
            else if (product == "grapefruit") {
                sum = 1.60 * count;
                Console.WriteLine($"{sum:f2}");
            }
            else if (product == "kiwi") {
                sum = 3.00 * count;
                Console.WriteLine($"{sum:f2}");
            }
            else if (product == "pineapple") {
                sum = 5.60 * count;
                Console.WriteLine($"{sum:f2}");
            }
            else if (product == "grapes") {
                sum = 4.20 * count;
                Console.WriteLine($"{sum:f2}");
            }
            else {
                Console.WriteLine("error");
            }
        }
        else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday") {
            if (product == "banana") {
                sum = 2.50 * count;
                Console.WriteLine($"{sum:f2}");
            }
            else if (product == "apple") {
                sum = 1.20 * count;
                Console.WriteLine($"{sum:f2}");
            }
            else if (product == "orange") {
                sum = 0.85 * count;
                Console.WriteLine($"{sum:f2}");
            }
            else if (product == "grapefruit") {
                sum = 1.45 * count;
                Console.WriteLine($"{sum:f2}");
            }
            else if (product == "kiwi") {
                sum = 2.70 * count;
                Console.WriteLine($"{sum:f2}");
            }
            else if (product == "pineapple") {
                sum = 5.50 * count;
                Console.WriteLine($"{sum:f2}");
            }
            else if (product == "grapes") {
                sum = 3.85 * count;
                Console.WriteLine($"{sum:f2}");
            }
            else {
                Console.WriteLine("error");
            }
        }
        else {
            Console.WriteLine("error");
        }
    }
}