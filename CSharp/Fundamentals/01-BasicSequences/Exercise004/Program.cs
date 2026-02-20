// Exercise004 - Sum of Two Integers
// Write a program that reads two integer values and
// displays the result of their sum.

Console.Write("Enter a value: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter another value: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = firstNumber + secondNumber;

Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is equal to {result}");
