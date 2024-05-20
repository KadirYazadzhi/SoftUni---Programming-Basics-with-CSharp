using System;

class VowelsSum {
    static void Main() {
        string input = Console.ReadLine();
        int sum = 0;
        for (int i = 0; i < input.Length; i++) {
            char letter = input[i];
            if (letter == 'a') {
                sum += 1;
            }
            if (letter == 'e') {
                sum += 2;
            }
            if (letter == 'i') {
                sum += 3;
            }
            if (letter == 'o') {
                sum += 4;
            }
            if (letter == 'u') {
                sum += 5;
            }
        }
        Console.WriteLine(sum);
    }
}