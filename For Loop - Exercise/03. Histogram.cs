using System;

class Histogram {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        
        double p1 = 0;
        double p2 = 0;
        double p3 = 0;
        double p4 = 0;
        double p5 = 0;
        
        for (int i = 0; i < n; i++) {
            int number = int.Parse(Console.ReadLine());
            
            if (number < 200) {
                p1++;
            }
            else if (number < 400 && number >= 200) {
                p2++;
            }
            else if (number < 600 && number >= 400) {
                p3++;
            }
            else if (number < 800 && number >= 600) {
                p4++;
            }
            else{
                p5++;
            }
        }
        
        double allP = p1 + p2 + p3 + p4 + p5;
        p1 = p1 / allP * 100;
        p2 = p2 / allP * 100;
        p3 = p3 / allP * 100;
        p4 = p4 / allP * 100;
        p5 = p5 / allP * 100;
        
        Console.WriteLine($"{p1:f2}%");
        Console.WriteLine($"{p2:f2}%");
        Console.WriteLine($"{p3:f2}%");
        Console.WriteLine($"{p4:f2}%");
        Console.WriteLine($"{p5:f2}%");
    }
}