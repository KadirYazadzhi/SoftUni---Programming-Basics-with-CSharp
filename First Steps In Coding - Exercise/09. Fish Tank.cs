using System;

public class FishTank {
    public static void Main(string[] args) {
        double length = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double procent = double.Parse(Console.ReadLine());
        
        double sum = (length * width * height) / 1000;
        sum = sum * (1 - (procent / 100));
        
        Console.WriteLine(sum);
        
    }
}