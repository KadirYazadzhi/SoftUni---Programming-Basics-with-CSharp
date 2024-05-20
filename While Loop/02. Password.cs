using System;

class Passwords {
    static void Main() {
        string name = Console.ReadLine();
        string password = Console.ReadLine();
       while (true) {
           string passwordLogin = Console.ReadLine();
           if (password == passwordLogin) {
               Console.WriteLine($"Welcome {name}!");
               break;
           }
       }
    }
}