using System;

class Program
{
    static void Main(string[] args)
    {
        int totalTickets = 0;
        int studentTickets = 0;
        int standardTickets = 0;
        int kidTickets = 0;

        while (true)
        {
            string movieName = Console.ReadLine();
            if (movieName == "Finish")
            {
                break;
            }

            int freeSeats = int.Parse(Console.ReadLine());
            int ticketsSold = 0;

            while (ticketsSold < freeSeats)
            {
                string ticketType = Console.ReadLine();
                if (ticketType == "End")
                {
                    break;
                }

                ticketsSold++;
                totalTickets++;

                if (ticketType == "student")
                {
                    studentTickets++;
                }
                else if (ticketType == "standard")
                {
                    standardTickets++;
                }
                else if (ticketType == "kid")
                {
                    kidTickets++;
                }
            }

            double percentageFull = (double)ticketsSold / freeSeats * 100;
            Console.WriteLine($"{movieName} - {percentageFull:F2}% full.");
        }

        double studentPercentage = (double)studentTickets / totalTickets * 100;
        double standardPercentage = (double)standardTickets / totalTickets * 100;
        double kidPercentage = (double)kidTickets / totalTickets * 100;

        Console.WriteLine($"Total tickets: {totalTickets}");
        Console.WriteLine($"{studentPercentage:F2}% student tickets.");
        Console.WriteLine($"{standardPercentage:F2}% standard tickets.");
        Console.WriteLine($"{kidPercentage:F2}% kids tickets.");
    }
}
