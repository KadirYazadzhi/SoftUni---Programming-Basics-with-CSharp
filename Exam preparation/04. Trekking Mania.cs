using System;

namespace CatWalkings {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            double countMusala = 0;
            double countMonblan = 0;
            double countKilimanjaro = 0;
            double countK2 = 0;
            double countEverest = 0;
            double totalCount = 0;

            for (int i = 0; i < n; i++) {
                int peopleCount = int.Parse(Console.ReadLine());
                totalCount += peopleCount;

                if (peopleCount <= 5) {
                    countMusala += peopleCount;
                } 
                else if (peopleCount <= 12) {
                    countMonblan += peopleCount;
                } 
                else if (peopleCount <= 25) {
                    countKilimanjaro += peopleCount;
                } 
                else if (peopleCount <= 40) {
                    countK2 += peopleCount;
                } 
                else {
                    countEverest += peopleCount;
                }
            }

            double percentageMusala = (countMusala / totalCount) * 100;
            double percentageMonblan = (countMonblan / totalCount) * 100;
            double percentageKilimanjaro = (countKilimanjaro / totalCount) * 100;
            double percentageK2 = (countK2 / totalCount) * 100;
            double percentageEverest = (countEverest / totalCount) * 100;

            Console.WriteLine($"{percentageMusala:F2}%");
            Console.WriteLine($"{percentageMonblan:F2}%");
            Console.WriteLine($"{percentageKilimanjaro:F2}%");
            Console.WriteLine($"{percentageK2:F2}%");
            Console.WriteLine($"{percentageEverest:F2}%");
        }
    }
}
