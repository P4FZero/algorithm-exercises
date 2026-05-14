// Exercise006 - Fibonacci Procedure (Challenge)
// Write a program that defines a method named Fibonacci()
// which receives the number of terms to generate
// and displays the Fibonacci sequence accordingly.

int numberOfTerms = GetNumber("Enter the number of Fibonacci terms to generate");

Fibonacci(numberOfTerms);

static void Fibonacci(int numberOfTerms)
{
  if (numberOfTerms <= 0)
  {
    WriteColored("Please enter a positive number.", ConsoleColor.Red);
    return;
  }

  int termA = 0;
  int termB = 1;

  for (int index = 0; index < numberOfTerms; index++)
  {
    Console.WriteLine(termB);

    int termC = termA + termB;
    termA = termB;
    termB = termC;
  }
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
