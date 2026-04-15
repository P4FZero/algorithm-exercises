// Exercise008 - Multiples of 10 in Array
// Write a program that reads 15 numbers into an array,
// displays all values, and then shows the indices
// where the numbers are multiples of 10.

Console.WriteLine("Please enter 15 numbers.\n");

int[] numbers = new int[15];

for (int index = 0; index < numbers.Length; index++)
{
  Console.Write($"Enter number #{index + 1}: ");
  numbers[index] = Convert.ToInt32(Console.ReadLine());
}

Console.Clear();
Console.WriteLine("Values entered:\n");

foreach (int number in numbers)
{
  Console.WriteLine(number);
}

Console.WriteLine("\nIndices of values that are multiples of 10:\n");

bool found = false;

for (int index = 0; index < numbers.Length; index++)
{
  if (numbers[index] % 10 == 0)
  {
    Console.WriteLine($"Index {index} -> Value {numbers[index]}");
    found = true;
  }
}

if (!found)
  Console.WriteLine("No multiples of 10 found.");
