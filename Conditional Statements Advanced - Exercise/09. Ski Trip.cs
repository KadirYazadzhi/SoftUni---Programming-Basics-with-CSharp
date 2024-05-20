using System;

public class SkiTrip
{
    public static void Main(string[] args)
    {
       int days = int.Parse(Console.ReadLine());
       string type = Console.ReadLine();
       string positiveOrNegative = Console.ReadLine();
       
       double sum;
       if (type == "room for one person") {
           sum = 18 * (days - 1);
       }
       else if (type == "apartment") {
           sum = 25 * (days - 1);
           if (days < 10) {
               sum *= 0.7;
           }
           else if (days > 10 && days <= 15) {
               sum *= 0.65;
           }
           else {
               sum *= 0.5;
           }
       }
       else {
           sum = 35 * (days - 1);
           if (days < 10) {
               sum *= 0.8;
           }
           else if (days > 10 && days <= 15) {
               sum *= 0.85;
           }
           else {
               sum *= 0.8;
           }
       }
       
       if (positiveOrNegative == "positive") {
           sum *= 1.25;
       }
       else {
           sum *= 0.9;
       }
       
       Console.WriteLine($"{sum:f2}");
    }
}