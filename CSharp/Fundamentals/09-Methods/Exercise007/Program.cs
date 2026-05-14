// Exercise007 - Average Function
// Write a program that defines a function named Average()
// which receives two student grades
// and returns the calculated average value.

double firstGrade = GetGrade("Enter the first grade");
double secondGrade = GetGrade("Enter the second grade");
double average = Average(firstGrade, secondGrade);
string studentStatus = Status(average);

WriteColored($"The average grade of {firstGrade} and {secondGrade} is {average:F1}", ConsoleColor.Cyan);

ConsoleColor statusColor = studentStatus switch
{
  "Failed" => ConsoleColor.Red,
  "Recovery" => ConsoleColor.Magenta,
  _ => ConsoleColor.Blue
};

WriteColored($"Status: {studentStatus}", statusColor);

static double Average(double firstGrade, double secondGrade)
{
  return (firstGrade + secondGrade) / 2;
}

static double GetGrade(string message)
{
  while (true)
  {
    Console.Write($"{message}: ");
    string? input = Console.ReadLine();

    if (double.TryParse(input, out double number) && number >= 0 && number <= 10)
      return number;

    WriteColored("Please enter a valid grade.", ConsoleColor.Red);
  }
}

static string Status(double grade) => grade switch
{
  < 5.0 => "Failed",
  < 7.0 => "Recovery",
  _ => "Approved"
};

static void WriteColored(string message, ConsoleColor color)
{
  Console.ForegroundColor = color;
  Console.WriteLine(message);
  Console.ResetColor();
}
