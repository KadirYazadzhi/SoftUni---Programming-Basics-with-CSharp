using System;

namespace ExamStatistics {
    class Program {
        static void Main(string[] args) {
            int numberOfStudents = int.Parse(Console.ReadLine());

            int topStudentsCount = 0;
            int betweenFourAndFiveCount = 0;
            int betweenThreeAndFourCount = 0;
            int failCount = 0;
            double sumOfGrades = 0.0;

            for (int i = 0; i < numberOfStudents; i++) {
                double grade = double.Parse(Console.ReadLine());
                sumOfGrades += grade;

                if (grade >= 5.00) {
                    topStudentsCount++;
                }
                else if (grade >= 4.00 && grade <= 4.99) {
                    betweenFourAndFiveCount++;
                }
                else if (grade >= 3.00 && grade <= 3.99) {
                    betweenThreeAndFourCount++;
                }
                else if (grade < 3.00) {
                    failCount++;
                }
            }

            double topStudentsPercentage = (double)topStudentsCount / numberOfStudents * 100;
            double betweenFourAndFivePercentage = (double)betweenFourAndFiveCount / numberOfStudents * 100;
            double betweenThreeAndFourPercentage = (double)betweenThreeAndFourCount / numberOfStudents * 100;
            double failPercentage = (double)failCount / numberOfStudents * 100;

            double averageGrade = sumOfGrades / numberOfStudents;

            Console.WriteLine($"Top students: {topStudentsPercentage:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {betweenFourAndFivePercentage:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {betweenThreeAndFourPercentage:F2}%");
            Console.WriteLine($"Fail: {failPercentage:F2}%");
            Console.WriteLine($"Average: {averageGrade:F2}");
        }
    }
}