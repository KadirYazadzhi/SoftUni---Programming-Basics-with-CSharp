using System;

public class InvalidNumber {
    public static void Main(string[] args) {
        int num = int.Parse(Console.ReadLine());
        if (num != 0 && num < 100 || num > 200) {
            Console.WriteLine("invalid");
        }
    }
}