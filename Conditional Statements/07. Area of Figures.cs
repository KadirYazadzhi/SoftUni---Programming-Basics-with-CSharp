using System;

public class AreaOfFigures {
    public static void Main(string[] args) {
        string figure = Console.ReadLine();
        
        if (figure == "square") {
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine(a * a);
        }
        else if (figure == "rectangle") {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(a * b);
        }
        else if (figure == "circle") {
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine(a * a * Math.PI);
        }
        else if (figure == "triangle") {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine((a * b) / 2);
        }
    }
}