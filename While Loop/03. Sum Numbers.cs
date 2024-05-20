using System;

class SumNumbers {
    static void Main() {
        int number = int.Parse(Console.ReadLine());
        
        int sum = 0;
        while(sum < number) {
            int num = int.Parse(Console.ReadLine());
            sum += num;
            
            if (sum >= number) {
                Console.WriteLine(sum);
                break;
            }
        }
    }
}