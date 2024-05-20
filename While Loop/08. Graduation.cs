using System;

class Graduation{
    static void Main() {
        string name = Console.ReadLine();
        
        int countBadGrade = 0;
        int count = 0;
        double sumGrade = 0;
        
        while (true) {
            double grade = double.Parse(Console.ReadLine());
            
            if (grade < 4.00) { 
                countBadGrade++;
                if (countBadGrade >= 2) {
                    Console.WriteLine($"{name} has been excluded at {count + 1} grade"); 
                    break;
                }
            } else {
                sumGrade += grade;
                count++;
                
                if (count >= 12) {
                    double average = sumGrade / count;
                    Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
                    break;
                }
            }
        }
    }
}