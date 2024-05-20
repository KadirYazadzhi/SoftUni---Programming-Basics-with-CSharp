using System;

class LeftAndRightSum {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        int left = 0;
        int right = 0;
        
        for (int i = 0; i < n * 2; i++) {
            int number = int.Parse(Console.ReadLine());
            
            if (i < n) {
                left += number;
            }
            else {
                right += number;
            }
        }
        
        if (right == left) {
            Console.WriteLine($"Yes, sum = {left}");
        }
        else {
            if (right > left) {
                Console.WriteLine($"No, diff = {right - left}");
            }
            else {
                Console.WriteLine($"No, diff = {left - right}");
            }
        }
    }
}