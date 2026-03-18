// Exercise001 - Integer Comparison
// Write a program that reads two integers and compares them,
// displaying whether the first value is greater, the second
// value is greater, or if both values are equal.

Console.Write("Enter the first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
  Console.WriteLine("The first value is greater than the second value.");
else if (firstNumber < secondNumber)
  Console.WriteLine("The second value is greater than the first value.");
else
  Console.WriteLine("Both values are equal.");
