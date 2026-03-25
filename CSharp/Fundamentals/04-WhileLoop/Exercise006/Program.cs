// Exercise006 - Countdown with Divisible Highlight
// Write a program that displays a countdown from 30 to 1,
// highlighting numbers that are divisible by 4 using brackets.

int count = 30;

while (count >= 1)
{
  string output = count % 4 == 0 ? $"[{count}]" : count.ToString();
  Console.WriteLine(output);
  count--;
}
