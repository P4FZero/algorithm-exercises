// Exercise010 - Search Key in Random Array
// Write a program that fills an array with 30 random numbers
// between 1 and 15. Then, read a number (key) from the user
// and display the indices where the key is found,
// as well as how many times it appears.

Console.Clear();
Console.Title = "Search Key in Random Array";
Console.WriteLine("=== Search Key in Random Array ===\n");

int[] numbers = new int[30];
PopulateWithRandomNumbers(numbers);

int key = AskForNumberInRange("Enter a number to search (between 1 and 15)", 1, 15);

int count = SearchKey(numbers, key);

if (count > 0)
  WriteColored($"The value {key} was found {count} time(s).", ConsoleColor.Green);
else
  WriteColored($"The value {key} was not found in the array.", ConsoleColor.Red);

static int AskForNumber(string message)
{
  while (true)
  {
    Console.Write($"{message}: ");

    if (int.TryParse(Console.ReadLine(), out int number))
      return number;

    WriteColored("Invalid Input. Only integer values are allowed.\n", ConsoleColor.Red);
  }
}

static int AskForNumberInRange(string message, int min, int max)
{
  while (true)
  {
    int number = AskForNumber(message);

    if (number >= min && number <= max)
      return number;

    WriteColored($"Invalid input. Please enter a valid number between {min} and {max}.\n", ConsoleColor.Red);
  }
}

static void PopulateWithRandomNumbers(int[] numbers)
{
  Random randomNumber = new();

  for (int index = 0; index < numbers.Length; index++)
  {
    numbers[index] = randomNumber.Next(1, 16);
  }
}

static int SearchKey(int[] numbers, int key)
{
  int count = 0;

  for (int index = 0; index < numbers.Length; index++)
  {
    if (numbers[index] == key)
    {
      Console.WriteLine($"Found at index {index}");
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
