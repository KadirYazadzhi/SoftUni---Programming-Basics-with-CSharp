using System;

class Cake {
    static void Main() {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
          
        int sum = num1 * num2;
          
        while(true) {
                string input = Console.ReadLine();
                
                if (input == "STOP") {
                    Console.WriteLine($"{sum} pieces are left.");
                    break;
                }
              else {
                  int pieces = int.Parse(input);
                  sum -= pieces;
                  if (sum < 0) {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(sum)} pieces more.");
                    break;
                }
            }
        }
    }
}