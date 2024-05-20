using System;

public class TradeCommissions {
    public static void Main(string[] args) {
        string town = Console.ReadLine();
        double number = double.Parse(Console.ReadLine());
        
        double sum;
        if (town == "Sofia") {
            if (number >= 0 && number <= 500) {
                sum = number * 0.05;
                Console.WriteLine($"{sum:f2}");
            }
            else if (number > 500 && number <= 1000) {
                sum = number * 0.07;
                Console.WriteLine($"{sum:f2}");
            }
            else if (number > 1000 && number <= 10000) {
                sum = number * 0.08;
                Console.WriteLine($"{sum:f2}");
            }
            else if (number > 10000) {
                sum = number * 0.12;
                Console.WriteLine($"{sum:f2}");
            }
            else {
                Console.WriteLine("error");
            }
        }
        else if (town == "Varna") {
            if (number >= 0 && number <= 500) {
                sum = number * 0.045;
                Console.WriteLine($"{sum:f2}");
            }
            else if (number > 500 && number <= 1000) {
                sum = number * 0.075;
                Console.WriteLine($"{sum:f2}");
            }
            else if (number > 1000 && number <= 10000) {
                sum = number * 0.10;
                Console.WriteLine($"{sum:f2}");
            }
            else if (number > 10000) {
                sum = number * 0.13;
                Console.WriteLine($"{sum:f2}");
            }
            else {
                Console.WriteLine("error");
            }
        }
        else if (town == "Plovdiv") {
            if (number >= 0 && number <= 500) {
                sum = number * 0.055;
                Console.WriteLine($"{sum:f2}");
            }
            else if (number > 500 && number <= 1000) {
                sum = number * 0.08;
                Console.WriteLine($"{sum:f2}");
            }
            else if (number > 1000 && number <= 10000) {
                sum = number * 0.12;
                Console.WriteLine($"{sum:f2}");
            }
            else if (number > 10000) {
                sum = number * 0.145;
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