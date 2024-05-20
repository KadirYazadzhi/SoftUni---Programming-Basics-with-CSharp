using System;

public class WorkingHours {
    public static void Main(string[] args) {
        double hours = double.Parse(Console.ReadLine());
        string day = Console.ReadLine();
        
        if (day == "Sunday" || hours < 10 || hours > 18) {
            Console.WriteLine("closed");
        }
        else {
            Console.WriteLine("open");
        }
    }
}