using System;

namespace BacheloretteParty {
    class Program {
        static void Main(string[] args) {
            double partyPrice = double.Parse(Console.ReadLine());
            int loveMessages = int.Parse(Console.ReadLine());
            int waxRoses = int.Parse(Console.ReadLine());
            int keychains = int.Parse(Console.ReadLine());
            int caricatures = int.Parse(Console.ReadLine());
            int luckySurprises = int.Parse(Console.ReadLine());

            double loveMessagePrice = 0.60;
            double waxRosePrice = 7.20;
            double keychainPrice = 3.60;
            double caricaturePrice = 18.20;
            double luckySurprisePrice = 22.00;

            double totalLoveMessages = loveMessages * loveMessagePrice;
            double totalWaxRoses = waxRoses * waxRosePrice;
            double totalKeychains = keychains * keychainPrice;
            double totalCaricatures = caricatures * caricaturePrice;
            double totalLuckySurprises = luckySurprises * luckySurprisePrice;

            double totalRevenue = totalLoveMessages + totalWaxRoses + totalKeychains + totalCaricatures + totalLuckySurprises;

            int totalItems = loveMessages + waxRoses + keychains + caricatures + luckySurprises;

            if (totalItems >= 25) {
                totalRevenue *= 0.65; 
            }

            double hostingExpenses = totalRevenue * 0.10;

            double finalProfit = totalRevenue - hostingExpenses;

            if (finalProfit >= partyPrice) {
                double moneyLeft = finalProfit - partyPrice;
                Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
            }
            else {
                double moneyNeeded = partyPrice - finalProfit;
                Console.WriteLine($"Not enough money! {moneyNeeded:F2} lv needed.");
            }
        }
    }
}