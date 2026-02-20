// Exercise006 - Predecessor and Successor
// Write a program that reads an integer and displays
// its predecessor and its successor.

Console.Write("Type a number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The predecessor of {number} is {number - 1}");
Console.WriteLine($"The successor of {number} is {number + 1}");
