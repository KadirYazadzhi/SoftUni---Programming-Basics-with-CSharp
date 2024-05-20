using System;

class Moving {
    static void Main() {
       int num1 = int.Parse(Console.ReadLine());
       int num2 = int.Parse(Console.ReadLine());
       int num3 = int.Parse(Console.ReadLine());
       
       int sum = num1 * num2 * num3;
       
       while (true) {
           string input = Console.ReadLine();
           
           if (input == "Done") {
               Console.WriteLine($"{sum} Cubic meters left.");
               break;
           }
           else {
               int meter = int.Parse(input);
               sum -= meter;
               if (sum < 0) {
                   Console.WriteLine($"No more free space! You need {Math.Abs(sum)} Cubic meters more.");
                   break;
               }
           }
       }
    }
}