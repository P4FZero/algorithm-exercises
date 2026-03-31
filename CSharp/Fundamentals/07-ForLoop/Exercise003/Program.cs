// Exercise003 - Multiplication Table with For Loop
// Write a program that reads a number and displays its
// multiplication table from 1 to 10 using a for loop.

Console.Write("Enter a number to see its multiplication table: ");
int multiplicand = Convert.ToInt32(Console.ReadLine());

for (int multiplier = 1; multiplier <= 10; multiplier++)
  Console.WriteLine($"{multiplicand} * {multiplier} = {multiplicand * multiplier}");
