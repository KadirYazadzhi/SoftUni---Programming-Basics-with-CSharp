using System;

public class SummerOutfit {
    public static void Main(string[] args) {
        int gradus = int.Parse(Console.ReadLine());
        string time = Console.ReadLine();
        
        string outfit;
        string shoes;
        
        if (time == "Morning") {
            if (gradus >= 10 && gradus <= 18) {
                outfit = "Sweatshirt";
                shoes = "Sneakers";
            }
            else if (gradus > 18 && gradus <= 24) {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            else {
                outfit = "T-Shirt";
                shoes = "Sandals";
            }
        }
        else if (time == "Afternoon") {
            if (gradus >= 10 && gradus <= 18) {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            else if (gradus > 18 && gradus <= 24) {
                outfit = "T-Shirt";
                shoes = "Sandals";
            }
            else {
                outfit = "Swim Suit";
                shoes = "Barefoot";
            }
        }
        else {
                outfit = "Shirt";
                shoes = "Moccasins";
        }
        
        Console.WriteLine($"It's {gradus} degrees, get your {outfit} and {shoes}.");
    }
}