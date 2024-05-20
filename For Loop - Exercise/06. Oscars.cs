using System;

class Oscars {
    static void Main() {
       string actorName = Console.ReadLine();
       double tochki = double.Parse(Console.ReadLine());
       int n = int.Parse(Console.ReadLine());
       
       for (int i = 1; i <= n; i++) {
           string name = Console.ReadLine();
           double t = double.Parse(Console.ReadLine());
           
           tochki += name.Length * t / 2;
           if (tochki >= 1250.5) {
               Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {tochki:f1}!");
               break;
           }
       }
       
       if (tochki < 1250.5) {
           double answer = 1250.5 - tochki;
           Console.WriteLine($"Sorry, {actorName} you need {answer:f1} more!");
       }
    }
}