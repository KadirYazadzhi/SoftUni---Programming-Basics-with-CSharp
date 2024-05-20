using System;

class AccountBalance {
    static void Main() {
        double sum = 0;
        
        while (true) {
            string input = Console.ReadLine();
            
            if (input == "NoMoreMoney") {
                Console.WriteLine($"Total: {sum:f2}");
                break;
            }
            
            if (double.TryParse(input, out double num)) {
                if (num < 0) {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine($"Total: {sum:f2}");
                    break;
                }
                sum += num;
                Console.WriteLine($"Increase: {num:f2}");
            } 
        }
    }
}