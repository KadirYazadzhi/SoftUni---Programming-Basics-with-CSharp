using System;

public class EvenOrOdd {
    public static void Main(string[] args) {
        int number = int.Parse(Console.ReadLine());
        
        if (number % 2 == 0) {
            Console.WriteLine("even");
        }
        else {
            Console.WriteLine("odd");
        }
        
    }
}
