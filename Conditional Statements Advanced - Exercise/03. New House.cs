using System;

public class NewHouse
{
    public static void Main(string[] args)
    {
        string type = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());
        int budjet = int.Parse(Console.ReadLine());
        
        double sum;
        
        if (type == "Roses") {
            sum = 5 * count;
            if (count > 80) {
                sum *= 0.9;
            }
        }
        else if (type == "Dahlias") {
            sum = 3.80 * count;
            if (count > 90) {
                sum *= 0.85;
            }
        }
        else if (type == "Tulips") {
            sum = 2.80 * count;
            if (count > 80) {
                sum *= 0.85;
            }
        }
        else if (type == "Narcissus") {
            sum = 3 * count;
            if (count < 120) {
                sum *= 1.15;
            }
        }
        else {
            sum = 2.50 * count;
            if (count < 80) {
                sum *= 1.20;
            }
        }
        
        double answer;
        if (budjet >= sum) {
            answer = budjet - sum;
            Console.WriteLine($"Hey, you have a great garden with {count} {type} and {answer:f2} leva left.");
        }
        else {
            answer = sum - budjet;
            Console.WriteLine($"Not enough money, you need {answer:f2} leva more.");
        }
    }
}