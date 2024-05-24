using System;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 1111; i <= 9999; i++)
        {
            bool isSpecial = true;
            int currentNumber = i;

            while (currentNumber > 0)
            {
                int digit = currentNumber % 10;
                currentNumber /= 10;

                if (digit == 0 || N % digit != 0)
                {
                    isSpecial = false;
                    break;
                }
            }

            if (isSpecial)
            {
                Console.Write(i + " ");
            }
        }
    }
}
