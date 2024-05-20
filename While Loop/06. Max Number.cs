using System;

class MaxNumber {
    static void Main() {
        int max = -2147483648;
        
        while (true) {
            string input = Console.ReadLine();
            
            if (input == "Stop") {
                Console.WriteLine(max);
                break;
            }
            
            if (int.TryParse(input, out int inputNew)) {
                if (inputNew > max) {
                    max = inputNew;
                }
            } 
        }
    }
}