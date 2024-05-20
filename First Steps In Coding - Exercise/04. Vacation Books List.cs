using System;

public class VacationBooksList {
    public static void Main(string[] args) {
        int countPage = int.Parse(Console.ReadLine());
        int pagePerHour = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());
        
        int sum = (countPage / pagePerHour) / days;
        
        Console.WriteLine(sum);
    }
}