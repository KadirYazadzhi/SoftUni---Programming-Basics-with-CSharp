using System;

class ReadText {
    static void Main() {
       while (true) {
           string word = Console.ReadLine();
            if (word == "Stop") {
               break;
           }
           Console.WriteLine(word);
       }
    }
}