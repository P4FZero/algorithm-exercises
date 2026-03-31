// Exercise004 - Counting Up to a Given Number with For Loop
// Write a program that reads a positive integer and displays
// a count from 0 up to that value using a for loop,
// followed by the message "END".

Console.Write("Enter a positive integer: ");
int targetNumber = Convert.ToInt32(Console.ReadLine());

for (int count = 0; count <= targetNumber; count++)
  Console.WriteLine(count);

Console.WriteLine("END");
