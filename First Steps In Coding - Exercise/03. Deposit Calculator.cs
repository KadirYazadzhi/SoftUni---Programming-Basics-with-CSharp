using System;

public class DepositCalculator {
    public static void Main(string[] args) {
        double money = double.Parse(Console.ReadLine());
        int time = int.Parse(Console.ReadLine());
        double procent = double.Parse(Console.ReadLine());
        
        double sum = ((money * (procent / 100)) / 12) * time + money;
        Console.WriteLine(sum);
    }
}