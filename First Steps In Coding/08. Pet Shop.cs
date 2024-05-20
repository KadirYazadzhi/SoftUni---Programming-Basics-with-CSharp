using System;

public class PetShop {
    public static void Main(string[] args) {
        int countDogFood = int.Parse(Console.ReadLine());
        int countCatFood = int.Parse(Console.ReadLine());
        
        double sum = (countDogFood * 2.50) + (countCatFood * 4.00);
        Console.WriteLine($"{sum} lv.");
    }
}