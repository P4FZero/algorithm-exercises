// Exercise005 - Counting Up to a Given Number
// Write a program that reads a positive integer from the user
// and displays a count from 1 up to that number using a while loop,
// followed by the message "Finished!".

Console.Write("Enter a positive integer: ");
int countEnd = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nCounting from 1 to {countEnd}");

int countStart = 1;

while (countStart <= countEnd)
{
  Console.WriteLine(countStart++);
}

Console.WriteLine("Finished!");
