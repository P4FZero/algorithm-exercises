// Exercise003 - Number Statistics with Do-While Loop
// Write a program that reads multiple numbers using a do-while loop,
// asking the user whether to continue after each entry.
// At the end, display the sum of all values, the smallest value,
// the average, and how many numbers are even.

bool shouldContinue;
int sum = 0;
int smallestValue = int.MaxValue;
int numberCount = 0;
int totalEvenNumbers = 0;

do
{
  Console.Write("Enter a number: ");
  int number = Convert.ToInt32(Console.ReadLine());

  sum += number;
  numberCount++;

  smallestValue = Math.Min(smallestValue, number);

  if (number % 2 == 0)
    totalEvenNumbers++;

  Console.WriteLine($"Current sum: {sum}");

  Console.Write("Do you want to enter another number? (Y/N): ");
  char option = Console.ReadLine().ToUpper()[0];

  shouldContinue = option != 'N';

  Console.WriteLine("\n--------------------\n");
} while (shouldContinue);

double average = (double)sum / numberCount;

Console.WriteLine($"Sum of all numbers: {sum}");
Console.WriteLine($"Smallest value entered: {smallestValue}");
Console.WriteLine($"Average value: {average:F1}");
Console.WriteLine($"Number of even values: {totalEvenNumbers}");
