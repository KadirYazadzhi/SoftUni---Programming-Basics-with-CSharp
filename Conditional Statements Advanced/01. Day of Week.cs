using System;

public class DayOfWeek {
    public static void Main(string[] args) {
        int days = int.Parse(Console.ReadLine());
        string[] daysInWeek = new string[] { 
            "Monday", 
            "Tuesday", 
            "Wednesday", 
            "Thursday", 
            "Friday", 
            "Saturday", 
            "Sunday"};
        
            if (days > 7 || days < 1) {
                Console.WriteLine("Error");
            }
            else {
                Console.WriteLine(daysInWeek[days - 1]);
            }
    }
}