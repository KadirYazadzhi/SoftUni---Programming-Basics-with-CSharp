using System;

public class Repainting {
    public static void Main(string[] args) {
        double naylon = double.Parse(Console.ReadLine());
        double paint = double.Parse(Console.ReadLine());
        double razreditel = double.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        
        naylon = (naylon + 2) * 1.50;
        paint = (paint * 1.1) * 14.50;
        
        double sum = (naylon + paint + (razreditel * 5.00) + 0.40);
        sum = sum + ((sum * 0.3) * hours);
        
        Console.WriteLine(sum);
        
    }
}