// Exercise006 - Fill Array with Random Numbers
// Write a program that creates an array with 7 positions,
// fills it with random numbers, and displays the values.

int[] randomNumbers = new int[7];
Random random = new Random();

for (int index = 0; index < randomNumbers.Length; index++)
{
  randomNumbers[index] = random.Next(0, 101);
}

for (int index = 0; index < randomNumbers.Length; index++)
{
  Console.WriteLine($"#{index + 1} value: {randomNumbers[index]}");
}
