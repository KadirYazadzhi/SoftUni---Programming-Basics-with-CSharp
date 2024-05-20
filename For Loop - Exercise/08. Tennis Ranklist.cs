using System;

class TennisRanklist {
    static void Main() {
        int broiTurniri = int.Parse(Console.ReadLine());
        int tochki = int.Parse(Console.ReadLine());
        
        double countPositive = 0;
        double countAll = 0;
        
        double sum = 0;
        
        for (int i = 0; i < broiTurniri; i++) {
            string etap = Console.ReadLine();
            
            if (etap == "W") {
                sum += 2000;
                countAll++;
                countPositive++;
            }
            else if (etap == "F") {
                sum += 1200;
                countAll++;
            }
            else {
                sum += 720;
                countAll++;
            }
        }
        
        int average = (int)sum / (int)countAll;
        double all = sum + tochki;
        double procent = countPositive / countAll * 100;
        
        Console.WriteLine($"Final points: {all:f0}");
        Console.WriteLine($"Average points: {average:f0}");
        Console.WriteLine($"{procent:f2}%");
    }
}