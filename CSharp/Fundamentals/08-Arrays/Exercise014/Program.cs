// Exercise014 - Underage People Listing
// Write a program that reads the name and age of 9 people,
// storing the data in two related arrays.
// At the end, display only the names and ages of people under 18.

Console.Clear();
Console.Title = "Underage People Listing";
Console.WriteLine("=== Underage People Listing ===\n");

WriteColored("Please enter the name and age of 9 people.", ConsoleColor.Cyan);

const int TotalPeople = 9;
string[] names = new string[TotalPeople];
int[] ages = new int[TotalPeople];

AddPerson(names, ages);

WriteColored("Filtering people under 18...", ConsoleColor.Blue);
DisplayUnder(names, ages);

static void AddPerson(string[] names, int[] ages)
{
  int length = names.Length;

  for (int index = 0; index < length; index++)
  {
    names[index] = GetName($"Enter the name of person #{index + 1}");
    ages[index] = GetAge($"Enter the age of person #{index + 1}");
    Console.WriteLine();
  }
}

static void DisplayUnder(string[] names, int[] ages)
{
  int length = names.Length;
  bool found = false;

  for (int index = 0; index < length; index++)
  {
    if (ages[index] < 18)
    {
      Console.WriteLine($"Name: {names[index]} | Age: {ages[index]}");
      found = true;
    }
  }

  if (!found)
    WriteColored("No underage people found.", ConsoleColor.Red);
}

static string GetName(string message)
{
  while (true)
  {
    Console.Write($"{message}: ");
    Console.ForegroundColor = ConsoleColor.Green;
    string input = Console.ReadLine();
    string name = input?.Trim() ?? "";
    Console.ResetColor();

    if (!string.IsNullOrWhiteSpace(name) && !int.TryParse(name, out int result))
      return name;

    WriteColored("Invalid name. Please enter a valid name.", ConsoleColor.Red);
  }
}

static int GetAge(string message)
{
  while (true)
  {
    Console.Write($"{message}: ");


    Console.ForegroundColor = ConsoleColor.Green;
    if (int.TryParse(Console.ReadLine(), out int age) && age >= 0)
    {
      Console.ResetColor();
      return age;
    }

    WriteColored("Invalid age. Please enter a valid number.", ConsoleColor.Red);
  }
}

static void WriteColored(string message, ConsoleColor color)
{
  Console.ForegroundColor = color;
  Console.WriteLine($"{message}\n");
  Console.ResetColor();
}
