using System;

class HalfSumElement {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        
        int max = 2147483647;
        int sum = 0;
        for (int i = 0; i < n; i++) {
            int number = int.Parse(Console.ReadLine());
            if (number > max) {
                max = number;
            }
            sum += number;
        }
        sum -= max;
        
        if (sum == max) {
            Console.WriteLine("Yes");
            Console.WriteLine($"Sum = {sum}");
        }
        else {
            if (max > sum) {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {max - sum}");
            }
            else {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {sum - max}");
            }
        }
    }
}