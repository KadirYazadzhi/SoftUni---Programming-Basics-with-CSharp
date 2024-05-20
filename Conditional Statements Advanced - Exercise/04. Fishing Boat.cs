using System;

public class FishingBoat
{
    public static void Main(string[] args)
    {
        int budjet = int.Parse(Console.ReadLine());
        string sezon = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());
        
        double sum;
        
        if (sezon == "Spring") {
            sum = 3000;
        }
        else if (sezon == "Summer"|| sezon == "Autumn") {
            sum = 4200;
        }
        else {
            sum = 2600;
        }
        
        if (count <= 6) {
            sum *= 0.9;
        }
        else if (count > 6 && count <= 11) {
            sum *= 0.85;
        }
        else if (count > 12) {
            sum *= 0.75;
        }
        
        if (count % 2 == 0 && sezon != "Autumn") {
            sum *= 0.95;
        }
        
        double answer;
        if (budjet >= sum) {
            answer = budjet - sum;
            Console.WriteLine($"Yes! You have {answer:f2} leva left.");
        }
        else {
            answer = sum - budjet;
            Console.WriteLine($"Not enough money! You need {answer:f2} leva.");
        }
    }
}