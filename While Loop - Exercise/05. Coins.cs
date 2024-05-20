using System;

class VendingMachineChange {
    static void Main() {
        double change = double.Parse(Console.ReadLine());
        
        int remainingCents = (int)Math.Round(change * 100);

        int[] coins = { 200, 100, 50, 20, 10, 5, 2, 1 };
        int coinCount = 0;

        foreach (int coin in coins) {
            if (remainingCents == 0) break;

            coinCount += remainingCents / coin;
            remainingCents %= coin;
        }

        Console.WriteLine(coinCount);
    }
}