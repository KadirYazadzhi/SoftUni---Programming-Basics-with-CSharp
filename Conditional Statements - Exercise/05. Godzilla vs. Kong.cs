using System;

public class GodzillaVsKong {
    public static void Main(string[] args) {
        double budjet = double.Parse(Console.ReadLine());
        int broi = int.Parse(Console.ReadLine());
        double priceForOne = double.Parse(Console.ReadLine());
        
        double sum = broi * priceForOne;
        budjet *= 0.9;
        
        if (broi >= 150) {
            sum *= 0.9;
        }
        
        if (budjet < sum) {
            Console.WriteLine("Not enough money!");
            Console.WriteLine($"Wingard needs {String.Format("{0:0.00}", sum - budjet)} leva more.");
        }
        else {
            Console.WriteLine("Action!");
            Console.WriteLine($"Wingard starts filming with {String.Format("{0:0.00}", budjet - sum)} leva left.");
        }
    }
}