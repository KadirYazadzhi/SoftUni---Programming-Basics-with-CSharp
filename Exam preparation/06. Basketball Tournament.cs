using System;

namespace BasketballTournaments {
    class Program {
        static void Main(string[] args) {
            int totalGames = 0;
            int wonGames = 0;
            int lostGames = 0;

            while (true) {
                string tournamentName = Console.ReadLine();
                if (tournamentName == "End of tournaments") {
                    break;
                }

                int gamesCount = int.Parse(Console.ReadLine());
                for (int i = 1; i <= gamesCount; i++) {
                    int desiTeamPoints = int.Parse(Console.ReadLine());
                    int opponentTeamPoints = int.Parse(Console.ReadLine());
                    totalGames++;

                    if (desiTeamPoints > opponentTeamPoints) {
                        wonGames++;
                        int pointDifference = desiTeamPoints - opponentTeamPoints;
                        Console.WriteLine($"Game {i} of tournament {tournamentName}: win with {pointDifference} points.");
                    } else {
                        lostGames++;
                        int pointDifference = opponentTeamPoints - desiTeamPoints;
                        Console.WriteLine($"Game {i} of tournament {tournamentName}: lost with {pointDifference} points.");
                    }
                }
            }

            double winPercentage = (double)wonGames / totalGames * 100;
            double losePercentage = (double)lostGames / totalGames * 100;

            Console.WriteLine($"{winPercentage:F2}% matches win");
            Console.WriteLine($"{losePercentage:F2}% matches lost");
        }
    }
}
