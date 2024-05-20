using System;

class OddEvenSum {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        int even = 0;
        int odd = 0;
        
        for (int i = 0; i < n; i++) {
            int number = int.Parse(Console.ReadLine());
            
            if (i % 2 == 0) {
              even += number;
            }
            else {
               odd += number; 
            }
        }
        
        if (even == odd) {
            Console.WriteLine("Yes");
            Console.WriteLine($"Sum = {even}");
        }
        else {
            if (even > odd) {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {even - odd}");
            }
            else {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {odd - even}");
            }
        }
    }
}