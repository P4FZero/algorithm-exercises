// Exercise008 - Largest Value Function
// Write a program that defines a function named Greater()
// which receives three numbers as parameters
// and returns the largest value among them.

int firstNumber = GetNumber("Enter the first number");
int secondNumber = GetNumber("Enter the second number");
int thirdNumber = GetNumber("Enter the third number");
int greatestNumber = Greater(firstNumber, secondNumber, thirdNumber);

WriteColored($"Greater number: {greatestNumber}", ConsoleColor.Cyan);

// Alternative:
// return Math.Max(firstTerm, Math.Max(secondTerm, thirdTerm));
static int Greater(int firstTerm, int secondTerm, int thirdTerm)
{
  int greater = firstTerm;

  if (secondTerm > greater)
    greater = secondTerm;

  if (thirdTerm > greater)
    greater = thirdTerm;

  return greater;
}

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

static void WriteColored(string message, ConsoleColor color)
{
  Console.ForegroundColor = color;
  Console.WriteLine(message);
  Console.ResetColor();
}
