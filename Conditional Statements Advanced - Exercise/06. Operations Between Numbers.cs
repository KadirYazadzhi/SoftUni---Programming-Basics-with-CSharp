using System;

public class Operations
{
    public static void Main(string[] args)
    {
       int num1 = int.Parse(Console.ReadLine());
       int num2 = int.Parse(Console.ReadLine());
       string operation = Console.ReadLine();
       
       double answer;
       string evenOrOdd;
       if (operation == "+") {
           answer = num1 + num2;
           if (answer % 2 == 0) {
               evenOrOdd = "even";
           }
           else {
               evenOrOdd = "odd";
           }
           Console.WriteLine($"{num1} + {num2} = {answer} - {evenOrOdd}");
       }
       else if (operation == "-") {
           answer = num1 - num2;
           if (answer % 2 == 0) {
               evenOrOdd = "even";
           }
           else {
               evenOrOdd = "odd";
           }
           Console.WriteLine($"{num1} - {num2} = {answer} - {evenOrOdd}");
       }
       else if (operation == "*") {
           answer = num1 * num2;
           if (answer % 2 == 0) {
               evenOrOdd = "even";
           }
           else {
               evenOrOdd = "odd";
           }
           Console.WriteLine($"{num1} * {num2} = {answer} - {evenOrOdd}");
       }
       else if (operation == "/") {
           if (num2 == 0) {
               Console.WriteLine($"Cannot divide {num1} by zero");
           }
           else {
                answer = (double)num1 / num2; 
                Console.WriteLine($"{num1} / {num2} = {answer:f2}");
           }
       }
       else {
           if (num2 == 0) {
            Console.WriteLine($"Cannot divide {num1} by zero");
           }
           else {
            answer = num1 % num2; 
           Console.WriteLine($"{num1} % {num2} = {answer}");
           }
       }
    }
}