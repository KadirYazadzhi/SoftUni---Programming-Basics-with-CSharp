using System;

public class InchesToCentimeters
{
    public static void Main(string[] args)
    {
        double inch = double.Parse(Console.ReadLine());
        
        double centimiters = inch * 2.54;
        
        Console.WriteLine(centimiters);
    }
}