using System;

public class HotelRoom
{
    public static void Main(string[] args)
    {
       string month = Console.ReadLine();
       int days = int.Parse(Console.ReadLine());
       
       double studioPrice;
       double apartmentPrice;
       
       if (month == "May" || month == "October") {
           studioPrice = 50.00;
           apartmentPrice = 65.00;
           if (days > 7 && days < 14) {
               studioPrice *= 0.95;
           }
           if (days > 14) {
               studioPrice *= 0.7;
           }
       }
       else if (month == "June" || month == "September") {
           studioPrice = 75.20;
           apartmentPrice = 68.70;
           if (days > 14) {
               studioPrice *= 0.8;
           }
       }
       else {
           studioPrice = 76.00;
           apartmentPrice = 77.00;
        }
        
        if (days > 14) {
            apartmentPrice *= 0.9;
        }
        apartmentPrice *= days;
        studioPrice *= days;
        Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
        Console.WriteLine($"Studio: {studioPrice:f2} lv.");
    }
}