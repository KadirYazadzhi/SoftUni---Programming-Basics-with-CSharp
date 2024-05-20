using System;

public class PersonalTitles {
    public static void Main(string[] args) {
        double age = double.Parse(Console.ReadLine());
        string pol = Console.ReadLine();
        
        if (pol == "f") {
            if (age < 16) {
                Console.WriteLine("Miss");
            }
            else {
                Console.WriteLine("Ms.");
            }
        }
        else {
              if (age < 16) {
                Console.WriteLine("Master");
            }
            else {
                Console.WriteLine("Mr.");
            }
        }
    }
}