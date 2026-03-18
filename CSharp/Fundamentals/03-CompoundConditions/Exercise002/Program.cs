// Exercise002 - Student Grade Classification
// Write a program that reads two grades, calculates the average,
// and displays the student's status based on the result:
// Failed (up to 4.9), Recovery (5.0 to 6.9), or Approved (7.0 or higher).

Console.Write("Enter the first grade: ");
double firstGrade = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the second grade: ");
double secondGrade = Convert.ToDouble(Console.ReadLine());

double averageGrade = (firstGrade + secondGrade) / 2;
Console.WriteLine($"The student's average grade is: {averageGrade:F1}");

string status = averageGrade switch
{
  <= 4.9 => "Failed",
  <= 6.9 => "Recovery",
  _ => "Approved"
};

Console.WriteLine($"Status: {status}");
