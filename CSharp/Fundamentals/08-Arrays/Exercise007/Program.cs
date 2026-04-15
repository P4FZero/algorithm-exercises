// Exercise007 - Reverse List of Names
// Write a program that reads 7 names and stores them in an array,
// then displays all names in reverse order.

Console.WriteLine("Please, enter 7 names.\n");

string[] names = new string[7];

for (int index = 0; index < names.Length; index++)
{
  Console.Write($"Enter name #{index + 1}: ");
  names[index] = Console.ReadLine() ?? "No name entered";
}

Array.Reverse(names);

Console.WriteLine("\nNames in reverse order:\n");

foreach (string name in names)
{
  Console.WriteLine(name);
}
