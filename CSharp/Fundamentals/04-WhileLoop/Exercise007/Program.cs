// Exercise007 - Custom Range Counting
// Write a program that reads the starting value, ending value,
// and increment, then displays all values within the interval
// using a while loop, followed by the message "Finished!".

Console.Write("Enter the starting value: ");
int countStart = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the ending value: ");
int countEnd = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the increment value: ");
int countIncrement = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine("Counting through the specified range...\n");

Count(countStart, countEnd, countIncrement);

static void Count(int start, int end, int step)
{
  if (start < end)
  {
    while (start <= end)
    {
      Console.WriteLine(start);
      start += step;
    }
  }
  else
  {
    while (start >= end)
    {
      Console.WriteLine(start);
      start -= step;
    }
  }
}

Console.WriteLine("Finished!");
