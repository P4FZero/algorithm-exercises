// Exercise011 - Even and Odd Counter
// Write a program that reads 6 integer values from the user
// and counts how many are even and how many are odd.

int count = 0;
int evenCount = 0;
int oddCount = 0;

while (count < 6)
{
  Console.Write($"Enter number #{count + 1}: ");
  int userInput = Convert.ToInt32(Console.ReadLine());

  if (userInput % 2 == 0)
    evenCount++;
  else
    oddCount++;

  count++;

  Console.WriteLine("\n-------------------\n");
}

Console.WriteLine($"Total even numbers: {evenCount}");
Console.WriteLine($"Total odd numbers: {oddCount}");
