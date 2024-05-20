using System;

public class FoodDelivery {
    public static void Main(string[] args) {
        double chicken = double.Parse(Console.ReadLine());
        double fish = double.Parse(Console.ReadLine());
        double vegan = double.Parse(Console.ReadLine());
        
        chicken *= 10.35;
        fish *= 12.40;
        vegan *= 8.15;
        
        double sum = (chicken + fish + vegan) * 1.2 + 2.50;
        
        Console.WriteLine(sum);
    }
}