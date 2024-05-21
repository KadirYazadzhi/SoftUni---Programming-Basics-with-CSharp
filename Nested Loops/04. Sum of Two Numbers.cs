using System;

class SumOfTwoNumbers {
    static void Main() {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int spnum = int.Parse(Console.ReadLine());
       
       int counter = 0;
       bool isValid = true;
      for (int i = num1; i <= num2; i++) {
          for (int j = num1; j <= num2; j++) {
                counter++;
              if (i + j == spnum) {
                  Console.WriteLine($"Combination N:{counter} ({i} + {j} = {spnum})");
                  isValid = false;
                  break;
              }
            }
            if (isValid == false) {
                break;
            }
        }
        
        if (isValid) {
            Console.WriteLine($"{counter} combinations - neither equals {spnum}");
        }
    }
}