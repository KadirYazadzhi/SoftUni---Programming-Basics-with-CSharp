using System;

public class Cinema {
    public static void Main(string[] args) {
        string type = Console.ReadLine();
        int r = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        
        double sum;
        
        if (type == "Premiere") {
            sum = r * c * 12.00;
            Console.WriteLine($"{sum:f2} leva");
        }
        else if (type == "Normal") {
            sum = r * c * 7.50;
            Console.WriteLine($"{sum:f2} leva");
        }
        else {
            sum = r * c * 5.00;
            Console.WriteLine($"{sum:f2} leva");
        }
        
    }
}