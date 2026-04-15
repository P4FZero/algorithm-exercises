// Exercise015 - Filter Female Employees by Salary
// Write a program that reads the name, gender, and salary of 5 employees,
// storing the data in three related arrays.
// At the end, display only the data of female employees
// who earn more than 5000.

Console.Clear();
Console.Title = "Female Employees Salary Filter";
Console.WriteLine("=== Female Employees Salary Filter ===\n");

WriteColored("Please enter the data of 5 employees.", ConsoleColor.Cyan);

const int TotalEmployees = 5;
string[] names = new string[TotalEmployees];
char[] genders = new char[TotalEmployees];
decimal[] salaries = new decimal[TotalEmployees];

AddEmployee(names, genders, salaries);

WriteColored("Filtering female employees with salary above 5000...", ConsoleColor.Blue);
Console.Write("Press any key to view the filtered results...");
Console.ReadKey(true);
Console.Clear();

DisplayFemale(names, genders, salaries);

static void AddEmployee(string[] names, char[] genders, decimal[] salaries)
{
  int length = names.Length;

  for (int index = 0; index < length; index++)
  {
    names[index] = GetName($"Enter the name of employee #{index + 1}");
    genders[index] = GetGender($"Enter the gender of employee #{index + 1}");
    salaries[index] = GetSalary($"Enter the salary of employee #{index + 1}");
    Console.WriteLine();
  }
}

static void DisplayFemale(string[] names, char[] genders, decimal[] salaries)
{
  int length = names.Length;
  const decimal salaryThreshold = 5000;
  bool found = false;

  for (int index = 0; index < length; index++)
  {
    if (salaries[index] > salaryThreshold && genders[index] == 'F')
    {
      Console.WriteLine($"Name: {names[index]} | Gender: {genders[index]} | Salary: {salaries[index]:C}");

      found = true;
    }
  }

  if (!found)
  {
    WriteColored($"No female employees with salary above {salaryThreshold:C} found.", ConsoleColor.Red);
  }
}

static char GetGender(string message)
{
  while (true)
  {
    Console.Write($"{message}: ");
    Console.ForegroundColor = ConsoleColor.Green;
    string input = Console.ReadLine() ?? "";
    Console.ResetColor();

    if (!string.IsNullOrWhiteSpace(input))
    {
      char gender = char.ToUpper(input.Trim()[0]);

      if (gender == 'M' || gender == 'F')
        return gender;
    }

    WriteColored("Invalid gender. Please enter 'M' or 'F'.", ConsoleColor.Red);
  }
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

static decimal GetSalary(string message)
{
  while (true)
  {
    Console.Write($"{message}: ");
    Console.ForegroundColor = ConsoleColor.Green;
    if (decimal.TryParse(Console.ReadLine(), out decimal salary) && salary > 0)
    {
      Console.ResetColor();
      return salary;
    }

    WriteColored("Invalid salary. Please enter a valid number.", ConsoleColor.Red);
  }
}

static void WriteColored(string message, ConsoleColor color)
{
  Console.ForegroundColor = color;
  Console.WriteLine($"{message}\n");
  Console.ResetColor();
}
