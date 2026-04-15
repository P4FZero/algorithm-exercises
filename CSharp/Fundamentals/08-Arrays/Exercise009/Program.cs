// Exercise009 - Even Numbers and Their Positions
// Write a program that reads 10 integers into an array,
// then displays the even numbers and their respective indices.

Console.WriteLine("Please enter 10 integer numbers\n");

int[] numbers = new int[10];

for (int index = 0; index < numbers.Length; index++)
{
  Console.Write($"Enter number #{index + 1}: ");
  numbers[index] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("\nEven numbers and their indices:\n");

bool foundEven = false;

for (int index = 0; index < numbers.Length; index++)
{
  if (numbers[index] % 2 == 0)
  {
    Console.WriteLine($"Index {index} -> Value {numbers[index]}");
    foundEven = true;
  }
}

if (!foundEven)
  Console.WriteLine("No even numbers found.");
