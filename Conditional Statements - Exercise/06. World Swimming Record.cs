using System;

public class WorldSwimmingRecords {
    public static void Main(string[] args) {
        double recordInSeconds = double.Parse(Console.ReadLine());
        double distanceInMeters = double.Parse(Console.ReadLine());
        double timeForOneMeterInSeconds = double.Parse(Console.ReadLine());
        
        double resistanceSeconds = Math.Floor(distanceInMeters / 15) * 12.5;
        double ivanTimeInSeconds = (distanceInMeters * timeForOneMeterInSeconds) + resistanceSeconds;
        
        if (ivanTimeInSeconds < recordInSeconds) {
            Console.WriteLine($"Yes, he succeeded! The new world record is {ivanTimeInSeconds:f2} seconds.");
        }
        else {
            double secondsSlower = ivanTimeInSeconds - recordInSeconds;
            Console.WriteLine($"No, he failed! He was {secondsSlower:f2} seconds slower.");
        }
    }
}