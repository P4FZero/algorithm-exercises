// Exercise009 - Range Sum Function
// Write a program that defines a function named SuperAdder()
// which receives two numbers as parameters
// and returns the sum of all values within the interval.

int firstNumber = GetNumber("Enter the first number");
int secondNumber = GetNumber("Enter the second number");
int result = SuperAdder(firstNumber, secondNumber);

WriteColored($"Result: {result}", ConsoleColor.Cyan);

static int GetNumber(string message)
{
  while (true)
  {
    Console.Write($"{message}: ");
    string? input = Console.ReadLine();

    if (int.TryParse(input, out int number))
      return number;

    WriteColored("Please enter a valid integer.", ConsoleColor.Red);
  }
}

// Alternative:
// int totalNumbers = end - start + 1;
// return totalNumbers * (start + end) / 2;
static int SuperAdder(int firstTerm, int secondTerm)
{
  int result = 0;

  int start = Math.Min(firstTerm, secondTerm);
  int end = Math.Max(firstTerm, secondTerm);

  for (int number = start; number <= end; number++)
  {
    result += number;
  }

  return result;
}

static void WriteColored(string message, ConsoleColor color)
{
  Console.ForegroundColor = color;
  Console.WriteLine(message);
  Console.ResetColor();
}

