using System;

public class Times {
    public static void Main(string[] args) {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        
        minutes += 15;
        
        if (minutes >= 60) {
            hours++;
            minutes -= 60;
            
            if (hours > 23) {
                hours = 0;
            }
        }
        
        if (minutes < 10) {
            Console.WriteLine($"{hours}:0{minutes}");
        }
        else {
            Console.WriteLine($"{hours}:{minutes}");
        }
    }
}