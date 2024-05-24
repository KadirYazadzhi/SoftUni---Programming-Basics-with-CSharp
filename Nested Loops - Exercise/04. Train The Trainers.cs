using System;

class Program
{
    static void Main(string[] args)
    {
        int juryCount = int.Parse(Console.ReadLine());
        double totalSum = 0;
        int presentationCount = 0;

        while (true)
        {
            string presentationName = Console.ReadLine();
            if (presentationName == "Finish")
            {
                break;
            }

            double sumGrades = 0;
            for (int i = 0; i < juryCount; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                sumGrades += grade;
            }

            double averageGrade = sumGrades / juryCount;
            totalSum += averageGrade;
            presentationCount++;

            Console.WriteLine($"{presentationName} - {averageGrade:F2}.");
        }

        double finalAssessment = totalSum / presentationCount;
        Console.WriteLine($"Student's final assessment is {finalAssessment:F2}.");
    }
}