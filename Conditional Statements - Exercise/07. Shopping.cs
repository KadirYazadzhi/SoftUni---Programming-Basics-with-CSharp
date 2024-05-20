using System;

public class Shopping {
    public static void Main(string[] args) {
        double budjet = double.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        int P = int.Parse(Console.ReadLine());
        
        double videoCardPrice = N * 250;
        double processorPrice = videoCardPrice * 0.35 * M;
        double ramPrice = videoCardPrice * 0.1 * P;
        
        double sum = videoCardPrice + processorPrice + ramPrice;
        
        if (N > M) {
            sum *= 0.85;
        }
        double answer;
        if (budjet >= sum) {
            answer = budjet - sum;
            Console.WriteLine($"You have {answer:f2} leva left!");
        }
        else {
            answer = Math.Abs(sum - budjet);
            Console.WriteLine($"Not enough money! You need {answer:f2} leva more!");
        }
    }
}