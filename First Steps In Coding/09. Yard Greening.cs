using System;

public class YardGreening {
    public static void Main(string[] args) {
        double meters = double.Parse(Console.ReadLine());
        
        double discount = (meters * 7.61) * 0.18;
        double finalPrice = (meters * 7.61) - discount;
        
        Console.WriteLine($"The final price is: {finalPrice} lv.");
        Console.WriteLine($"The discount is: {discount} lv.");
    }
}