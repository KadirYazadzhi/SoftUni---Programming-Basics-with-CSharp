using System;

public class ToyShop {
    public static void Main(string[] args) {
        double price = double.Parse(Console.ReadLine());
        double puzzle = double.Parse(Console.ReadLine());
        double doll = double.Parse(Console.ReadLine());
        double bear = double.Parse(Console.ReadLine());
        double minions = double.Parse(Console.ReadLine());
        double truck = double.Parse(Console.ReadLine());
        
        double count = puzzle + doll + bear + minions + truck;
        
        puzzle *= 2.60;
        doll *= 3.00;
        bear *= 4.10;
        minions *= 8.20;
        truck *= 2.00;
        double sum = puzzle + doll + bear + minions + truck;
        
        if (count >= 50) {
            sum *= 0.75;
        }
        
        sum *= 0.9;
        
        if (sum >= price) {
            Console.WriteLine($"Yes! {String.Format("{0:0.00}", sum - price)} lv left.");
        }
        else {
            Console.WriteLine($"Not enough money! {String.Format("{0:0.00}",price - sum)} lv needed.");
        }
    }
}