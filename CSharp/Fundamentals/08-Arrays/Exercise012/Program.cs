// Exercise012 - Class Grades Analysis
// Write a program that reads the grades of 10 students into an array,
// then calculates the class average, counts how many students are above
// the average, determines the highest grade,
// and shows the indices where the highest grade appears.

Console.Clear();
Console.Title = "Class Grades Analysis";
Console.WriteLine("=== Class Grades Analysis ===\n");

double[] grades = new double[10];
GetGrades(grades);

Console.Write("\nPress any key to analyze...");
Console.ReadKey(true);
Console.Clear();
WriteColored("Analyzing class performance...\n", ConsoleColor.Blue);

double averageGrade = grades.Average();
Console.WriteLine($"Class average: {averageGrade:F1}");

int aboveTheAverage = CountAboveAverage(grades, averageGrade);
Console.WriteLine($"Number of students above the average: {aboveTheAverage}");

double highestGrade = grades.Max();
Console.WriteLine($"Highest grade: {highestGrade:F1}\n");

Console.WriteLine("Positions where the highest grade appears:");
DisplayHighestGradeIndex(grades, highestGrade);

static double AskForNumber(string message)
{
  while (true)
  {
    Console.Write($"{message}: ");

    if (double.TryParse(Console.ReadLine(), out double number) &&
        number >= 0 && number <= 10)
      return number;

    WriteColored("Invalid input. Please enter a valid grade between 0 and 10.\n", ConsoleColor.Red);
  }
}

static void DisplayHighestGradeIndex(double[] grades, double highestGrade)
{
  const double Tolerance = 0.0001;

  for (int index = 0; index < grades.Length; index++)
  {
    if (Math.Abs(grades[index] - highestGrade) < Tolerance)
    {
      Console.WriteLine($"Index {index} -> Grade {grades[index]}");
    }
  }
}

static void GetGrades(double[] grades)
{
  for (int index = 0; index < grades.Length; index++)
  {
    double grade = AskForNumber($"Enter the grade of student #{index + 1}");
    grades[index] = grade;
  }
}

static int CountAboveAverage(double[] grades, double averageGrade)
{
  int count = 0;

  foreach (double grade in grades)
  {
    if (grade > averageGrade)
    {
      count++;
    }
  }

  return count;
}

static void WriteColored(string message, ConsoleColor color)
{
  Console.ForegroundColor = color;
  Console.WriteLine(message);
  Console.ResetColor();
}
