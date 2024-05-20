using System;

class MinNumber {
    static void Main() {
        int min = 2147483647;
        
        while (true) {
            string input = Console.ReadLine();
            
            if (input == "Stop") {
                Console.WriteLine(min);
                break;
            }
            
            if (int.TryParse(input, out int inputNew)) {
                if (inputNew < min) {
                    min = inputNew;
                }
            } 
        }
    }
}