// Exercise009 - Sum of Decreasing Sequence
// Write a program that calculates and displays the result of the sequence
// 500 + 450 + 400 + ... + 50 + 0 using a while loop.

int count = 500;
int total = 0;

while (count >= 0)
{
  total += count;
  count -= 50;
}

Console.WriteLine($"The sum from 500 down to 0 (step of 50): {total}");
