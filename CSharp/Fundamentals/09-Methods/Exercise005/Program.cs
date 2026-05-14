// Exercise005 - Custom Counter Method
// Write a program that defines a method named Counter()
// which receives a start value, an end value,
// and an increment value as parameters,
// then displays the counting sequence.

int start = GetNumber("Enter the starting value");
int end = GetNumber("Enter the ending value");
int increment = GetNumber("Enter the increment value");

Counter(start, end, increment);

static void Counter(int start, int end, int increment)
{
  if (increment <= 0)
  {
    WriteColored("Increment must be greater than zero.", ConsoleColor.Red);
    return;
  }

  if (start < end)
  {
    for (int number = start; number <= end; number += increment)
    {
      Console.WriteLine(number);
    }
  }
  else
  {
    for (int number = start; number >= end; number -= increment)
    {
      Console.WriteLine(number);
    }
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
