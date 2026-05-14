// Exercise003 - Largest Value Method
// Write a program that reads two values from the keyboard
// and passes them to a method named Greater()
// which determines and displays the larger value.
// If both values are equal, the method should display
// a message indicating that they are the same.

int firstNumber = GetNumber("Enter the first number");
int secondNumber = GetNumber("Enter the second number");
int? result = GetGreater(firstNumber, secondNumber);

if (result == null)
  WriteColored("Both numbers are equal", ConsoleColor.Cyan);
else
  WriteColored($"Greater number: {result}", ConsoleColor.Blue);

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

static int? GetGreater(int firstTerm, int secondTerm)
{
  if (firstTerm == secondTerm)
    return null;

  return firstTerm > secondTerm ? firstTerm : secondTerm;
}

static void WriteColored(string message, ConsoleColor color)
{
  Console.ForegroundColor = color;
  Console.WriteLine(message);
  Console.ResetColor();
}
