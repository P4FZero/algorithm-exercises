// Exercise004 - Even or Odd Method
// Write a program that reads an integer value
// and passes it to a method named IsEven()
// which checks and displays whether the number
// is even or odd.

int userValue = GetNumber("Enter an integer value");
bool isEven = IsEven(userValue);

if (isEven)
  WriteColored($"The number {userValue} is even.", ConsoleColor.Cyan);
else
  WriteColored($"The number {userValue} is odd.", ConsoleColor.Magenta);

static bool IsEven(int number)
{
  return number % 2 == 0;
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
