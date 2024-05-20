using System;

class CleverLily {
    static void Main() {
       int lilyAge = int.Parse(Console.ReadLine());
       double washerPrice = double.Parse(Console.ReadLine());
       int toyPrice = int.Parse(Console.ReadLine());
       
       double sum = 0;
       int countToys = 0;
       int plus = 10;
       
       for (int i = 1; i <= lilyAge; i++) {
           if (i % 2 == 0) {
               sum += plus;
               plus += 10;
           }
           else {
               countToys++;
           }
       }
       sum -= lilyAge / 2;
       sum += countToys * toyPrice;
       
       double answer = 0;
       if (sum >= washerPrice) {
           answer = sum - washerPrice;
           Console.WriteLine($"Yes! {answer:f2}");
       }
       else {
           answer = washerPrice - sum;
           Console.WriteLine($"No! {answer:f2}");
       }
    }
}