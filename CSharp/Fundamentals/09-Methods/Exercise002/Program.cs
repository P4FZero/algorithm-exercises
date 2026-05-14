// Exercise002 - Sum Method
// Write a program that reads two values from the keyboard
// and passes them to a method named Sum()
// which calculates and displays the result of the addition.

int firstNumber = GetNumber("Enter the first number");
int secondNumber = GetNumber("Enter the second number");
int result = Sum(firstNumber, secondNumber);

WriteColored($"{firstNumber} + {secondNumber} = {result}", ConsoleColor.Blue);

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

static int Sum(int firstTerm, int secondTerm)
{
  return firstTerm + secondTerm;
}

static void WriteColored(string message, ConsoleColor color)
{
  Console.ForegroundColor = color;
  Console.WriteLine(message);
  Console.ResetColor();
}
