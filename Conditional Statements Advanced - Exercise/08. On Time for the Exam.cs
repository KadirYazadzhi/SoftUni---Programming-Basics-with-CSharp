using System;

public class OnTime
{
    public static void Main(string[] args)
    {
        int examHours = int.Parse(Console.ReadLine());
        int minutesExam = int.Parse(Console.ReadLine());
        
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        
        int examTime = (examHours * 60) + minutesExam;
        int time = (hours * 60) + minutes;
        
        int difference = examTime - time;
        
        if (difference >= 0) {
            // On time or early
            if (difference == 0) {
                Console.WriteLine("On time");
            }
            else if (difference <= 30) {
                Console.WriteLine("On time");
                Console.WriteLine($"{difference} minutes before the start");
            } 
            else {
                hours = difference / 60;
                minutes = difference % 60;
                
                if (hours > 0) {
                    if (minutes < 10) {
                        Console.WriteLine("early");
                        Console.WriteLine($"{hours}:0{minutes} hours before the start");
                    } 
                    else {
                        Console.WriteLine("early");
                        Console.WriteLine($"{hours}:{minutes} hours before the start");
                    }
                } 
                else {
                    Console.WriteLine("early");
                    Console.WriteLine($"{minutes} minutes before the start");
                }
            }
        } 
        else {
            difference = Math.Abs(difference);
            hours = difference / 60;
            minutes = difference % 60;
            
            Console.WriteLine("Late");
            if (hours > 0) {
                if (minutes < 10) {
                    Console.WriteLine($"{hours}:0{minutes} hours after the start");
                } 
                else {
                    Console.WriteLine($"{hours}:{minutes} hours after the start");
                }
            } 
            else {
                Console.WriteLine($"{minutes} minutes after the start");
            }
        }
    }
}