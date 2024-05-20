using System;

class StepsTracker {
    static void Main() {
        const int goal = 10000;
        int totalSteps = 0;
        
        while (totalSteps < goal) {
            string input = Console.ReadLine();
            
            if (input == "Going home") {
                int homeSteps = int.Parse(Console.ReadLine());
                totalSteps += homeSteps;
                if (totalSteps >= goal) {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{totalSteps - goal} steps over the goal!");
                } else {
                    Console.WriteLine($"{goal - totalSteps} more steps to reach goal.");
                }
                return;
            } else {
                int steps = int.Parse(input);
                totalSteps += steps;
                if (totalSteps >= goal) {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{totalSteps - goal} steps over the goal!");
                }
            }
        }
    }
}