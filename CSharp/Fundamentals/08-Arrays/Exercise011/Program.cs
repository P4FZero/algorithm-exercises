// Exercise011 - Age Analysis in Array
// Write a program that reads the ages of 8 people into an array,
// then calculates the average age, identifies positions of people
// older than 25, determines the highest age,
// and shows the indices where the highest age appears.

Console.Clear();
Console.Title = "Age Analysis in Array";
Console.WriteLine("=== Age Analysis in Array ===\n");

int[] ages = new int[8];
GetAges(ages);

Console.Write("\nPress any key to analyze...");
Console.ReadKey(true);
Console.Clear();
WriteColored("Analyzing age data...\n", ConsoleColor.Blue);

double averageAge = ages.Average();
Console.WriteLine($"Average age: {averageAge:F1}\n");

Console.WriteLine("Positions of people older than 25:");
DisplayAgesAbove(ages, 25);

int highestAge = ages.Max();
Console.WriteLine($"\nHighest age: {highestAge}\n");

Console.WriteLine("Positions where the highest age appears:");
DisplayAgesEqualTo(ages, highestAge);

static int AskForNumber(string message)
{
  while (true)
  {
    Console.Write($"{message}: ");

    if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
      return number;

    WriteColored("Invalid input. Only positive integer values are allowed.\n", ConsoleColor.Red);
  }
}

static void DisplayAgesAbove(int[] ages, int threshold)
{
  bool found = false;

  for (int index = 0; index < ages.Length; index++)
  {
    if (ages[index] > threshold)
    {
      Console.WriteLine($"Index {index} -> Age {ages[index]}");
      found = true;
    }
  }

  if (!found)
    WriteColored($"No one older than {threshold} was found.", ConsoleColor.Red);
}

static void DisplayAgesEqualTo(int[] ages, int threshold)
{
  for (int index = 0; index < ages.Length; index++)
  {
    if (ages[index] == threshold)
    {
      Console.WriteLine($"Index {index} -> Age {ages[index]}");
    }
  }
}

static void GetAges(int[] ages)
{
  for (int index = 0; index < ages.Length; index++)
  {
    int age = AskForNumber($"Enter the age of person #{index + 1}");
    ages[index] = age;
  }
}

static void WriteColored(string message, ConsoleColor color)
{
  Console.ForegroundColor = color;
  Console.WriteLine(message);
  Console.ResetColor();
}
