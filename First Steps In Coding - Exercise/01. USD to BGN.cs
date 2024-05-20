using System;

public class USDtoBGN {
    public static void Main(string[] args) {
        double USD = double.Parse(Console.ReadLine());
        
        double BGN = USD * 1.79549;
        
        Console.WriteLine(BGN);
    }
}