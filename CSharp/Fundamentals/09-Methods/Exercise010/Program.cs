// Exercise010 - Power Function
// Write a program that defines a function named Power()
// which receives a base and an exponent as parameters
// and returns the result of the exponentiation.

int baseValue = GetNumber("Enter the base number");
int exponent = GetNumber("Enter the exponent number");
int result = Power(baseValue, exponent);

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

static int Power(int baseValue, int exponent)
{
  if (exponent < 0)
  {
    WriteColored("Negative exponents are not supported.", ConsoleColor.Red);
    return 0;
  }

  int result = 1;

  for (int index = 0; index < exponent; index++)
  {
    result *= baseValue;
  }

  return result;
}

static void WriteColored(string message, ConsoleColor color)
{
  Console.ForegroundColor = color;
  Console.WriteLine(message);
  Console.ResetColor();
}



