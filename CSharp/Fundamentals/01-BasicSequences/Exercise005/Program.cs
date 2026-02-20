// Exercise005 - Student Average Grade
// Write a program that reads two grades of a student
// and displays the average grade.

Console.Write("Grade 1: ");
double firstGrade = Convert.ToDouble(Console.ReadLine());

Console.Write("Grade 2: ");
double secondGrade = Convert.ToDouble(Console.ReadLine());

double averageGrade = (firstGrade + secondGrade) / 2;

Console.WriteLine($"The average between {firstGrade:F1} and {secondGrade:F1} is equal to {averageGrade:F1}");
