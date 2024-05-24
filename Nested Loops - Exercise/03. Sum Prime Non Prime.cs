using System;

class Program
{
    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }

    static void Main(string[] args)
    {
        int primeSum = 0;
        int nonPrimeSum = 0;

        while (true)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "stop")
            {
                break;
            }

            int number;
            if (!int.TryParse(input, out number))
            {
                continue;
            }

            if (number < 0)
            {
                Console.WriteLine("Number is negative.");
                continue;
            }

            if (IsPrime(number))
            {
                primeSum += number;
            }
            else
            {
                nonPrimeSum += number;
            }
        }

        Console.WriteLine("Sum of all prime numbers is: " + primeSum);
        Console.WriteLine("Sum of all non prime numbers is: " + nonPrimeSum);
    }
}
