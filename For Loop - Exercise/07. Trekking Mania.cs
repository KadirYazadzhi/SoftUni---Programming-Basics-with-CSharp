using System;

class ClimbingGroups {
    static void Main() {
        int groupCount = int.Parse(Console.ReadLine());

        int musala = 0;
        int montBlanc = 0;
        int kilimanjaro = 0;
        int k2 = 0;
        int everest = 0;
        int totalClimbers = 0;

        for (int i = 0; i < groupCount; i++) {
            int groupSize = int.Parse(Console.ReadLine());
            totalClimbers += groupSize;
            
            if (groupSize <= 5) {
                musala += groupSize;
            } else if (groupSize <= 12) {
                montBlanc += groupSize;
            } else if (groupSize <= 25) {
                kilimanjaro += groupSize;
            } else if (groupSize <= 40) {
                k2 += groupSize;
            } else {
                everest += groupSize;
            }
        }

        double musalaPercentage = (double)musala / totalClimbers * 100;
        double montBlancPercentage = (double)montBlanc / totalClimbers * 100;
        double kilimanjaroPercentage = (double)kilimanjaro / totalClimbers * 100;
        double k2Percentage = (double)k2 / totalClimbers * 100;
        double everestPercentage = (double)everest / totalClimbers * 100;

        Console.WriteLine($"{musalaPercentage:f2}%");
        Console.WriteLine($"{montBlancPercentage:f2}%");
        Console.WriteLine($"{kilimanjaroPercentage:f2}%");
        Console.WriteLine($"{k2Percentage:f2}%");
        Console.WriteLine($"{everestPercentage:f2}%");
    }
}