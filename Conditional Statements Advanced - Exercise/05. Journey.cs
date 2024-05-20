using System;

public class Journey
{
    public static void Main(string[] args)
    {
        double budjet = double.Parse(Console.ReadLine());
        string sezon = Console.ReadLine();
        
        string place;
        string country;
        double sum;
        if (budjet <= 100) {
            if (sezon == "summer") {
                place = "Camp";
                sum = budjet * 0.3;
            }
            else {
                sum = budjet * 0.7;
                place = "Hotel";
            }
            country = "Bulgaria";
        }
        else if (budjet > 100 && budjet <= 1000) {
              if (sezon == "summer") {
                sum = budjet * 0.4;
                 place = "Camp";
            }
            else {
                sum = budjet * 0.8;
                 place = "Hotel";
            }
            country = "Balkans";
        }
        else {
            sum = budjet * 0.9;
             place = "Hotel";
             country = "Europe";
        }
        
        Console.WriteLine($"Somewhere in {country}");
        Console.WriteLine($"{place} - {sum:f2}");
    }
}