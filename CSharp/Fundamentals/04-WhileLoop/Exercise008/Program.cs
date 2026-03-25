// Exercise008 - Sum of Even Numbers Sequence
// Write a program that calculates and displays the sum of the sequence
// 6 + 8 + 10 + ... + 100 using a while loop.

int count = 6;
int total = 0;

while (count <= 100)
{
  total += count;
  count += 2;
}

Console.WriteLine($"The sum of even numbers from 6 to 100: {total}");
