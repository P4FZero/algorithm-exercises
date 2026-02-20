// Exercise007 - Double and One Third
// Write a program that reads a real number and displays
// its double and one third.

Console.Write("Type a number: ");
double number = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"The double of {number} is {number * 2}");
Console.WriteLine($"One third of {number} is {number / 3:F5}");
