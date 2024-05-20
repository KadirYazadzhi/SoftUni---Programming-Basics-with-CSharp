using System;

class Sequence {
    static void Main() {
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= num; i = i * 2 + 1) {
            Console.WriteLine(i);
        }
    }
}