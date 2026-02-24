// Exercise003 - Student Performance Evaluation
// Write a program that reads a student's name and two grades,
// calculates the average, and determines whether the student
// achieved good performance (average above 7.0).

Console.Write("Enter the student's name: ");
string studentName = Console.ReadLine();

Console.Write("Enter the first grade: ");
double firstGrade = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the second grade: ");
double secondGrade = Convert.ToDouble(Console.ReadLine());

double averageGrade = (firstGrade + secondGrade) / 2;

Console.WriteLine($"{studentName}'s average grade is: {averageGrade:F1}.");

if (averageGrade > 7.0)
  Console.WriteLine("The student achieved good performance.");
else 
  Console.WriteLine("The student did not achieve good performance.");
