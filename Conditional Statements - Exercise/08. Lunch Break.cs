using System;

public class LunchBreak {
    public static void Main(string[] args) {
        string serialName = Console.ReadLine();
        double episodeTime = double.Parse(Console.ReadLine());
        double breakTime = double.Parse(Console.ReadLine());
        
        double otherTime = (breakTime / 8) + (breakTime / 4);
        
        breakTime -= otherTime;
        
        double answer;
        if (breakTime >= episodeTime) {
            answer = Math.Ceiling(breakTime - episodeTime);
            Console.WriteLine($"You have enough time to watch {serialName} and left with {answer:f0} minutes free time.");
        }
        else {
            answer = Math.Ceiling(episodeTime - breakTime);
            Console.WriteLine($"You don't have enough time to watch {serialName:f0}, you need {answer:f0} more minutes.");
        }
    }
}