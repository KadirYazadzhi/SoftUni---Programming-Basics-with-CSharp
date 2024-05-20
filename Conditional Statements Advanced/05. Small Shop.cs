using System;

public class SmallShop {
    public static void Main(string[] args) {
        string product = Console.ReadLine();
        string town = Console.ReadLine();
        double count = double.Parse(Console.ReadLine());
        
        if (town == "Sofia") {
            if (product == "coffee") {
                Console.WriteLine(0.5 * count);
            }
            else if (product == "water") {
                Console.WriteLine(0.8 * count);
            }
            else if (product == "beer") {
               Console.WriteLine(1.20 * count); 
            }
            else if (product == "sweets") {
                Console.WriteLine(1.45 * count);
            }
            else if (product == "peanuts") {
               Console.WriteLine(1.60 * count); 
            }
        }
        else if (town == "Plovdiv") {
            if (product == "coffee") {
                Console.WriteLine(0.4 * count);
            }
            else if (product == "water") {
                Console.WriteLine(0.7 * count);
            }
            else if (product == "beer") {
               Console.WriteLine(1.15 * count); 
            }
            else if (product == "sweets") {
                Console.WriteLine(1.30 * count);
            }
            else if (product == "peanuts") {
               Console.WriteLine(1.50 * count); 
            }
        }
        else if (town == "Varna") {
            if (product == "coffee") {
                Console.WriteLine(0.45 * count);
            }
            else if (product == "water") {
                Console.WriteLine(0.7 * count);
            }
            else if (product == "beer") {
               Console.WriteLine(1.10 * count); 
            }
            else if (product == "sweets") {
                Console.WriteLine(1.35 * count);
            }
            else if (product == "peanuts") {
               Console.WriteLine(1.55 * count); 
            }
        }
    }
}
