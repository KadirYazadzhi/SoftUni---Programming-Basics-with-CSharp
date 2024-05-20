using System;

public class WeekendOrWorkingDay {
    public static void Main(string[] args) {
        string day = Console.ReadLine();
        string[] daysInWeek = new string[] { 
            "Monday", 
            "Tuesday",
             "Wednesday", 
             "Thursday", 
             "Friday",
              "Saturday", 
              "Sunday"};
        
        bool isValidDay = false;
        
        for (int i = 0; i < 7; i++) {
            if (day == daysInWeek[i]) {
                isValidDay = true;
                if (i >= 0 && i <= 4) {
                    Console.WriteLine("Working day");
                }
                else if (i == 5 || i == 6) {
                    Console.WriteLine("Weekend");
                }
                break;
            }
        }
        
        if (!isValidDay) {
            Console.WriteLine("Error");
        }
    }
}