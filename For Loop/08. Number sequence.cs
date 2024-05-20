using System;

class NumberSequence {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        int min = 2147483647;
        int max = -2147483648;
        
        for (int i = 0; i < n; i++) {
            int number = int.Parse(Console.ReadLine());
           if (number < min) {
               min = number;
           } 
           if (number > max) {
               max = number;
           }
        }
        Console.WriteLine($"Max number: {max}");
        Console.WriteLine($"Min number: {min}");
    }
}