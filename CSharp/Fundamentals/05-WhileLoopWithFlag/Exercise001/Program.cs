// Exercise001 - Sum Until Sentinel Value
// Write a program that reads multiple numbers from the user
// and calculates their sum. The program stops when the value
// 1111 is entered (sentinel value).

Console.WriteLine("===== Sum Until Sentinel Value =====");
Console.WriteLine("Enter numbers to calculate the sum.");
Console.WriteLine("Type 1111 to stop.\n");

int sum = 0;
const int SentinelValue = 1111;

while (true)
{
  Console.Write("Enter a number: ");
  int number = Convert.ToInt32(Console.ReadLine());

  if (number == SentinelValue)
  {
    Console.WriteLine("Sentinel value (1111) detected. Stopping input...\n"); break;
  }

  sum += number;
  Console.WriteLine($"Current sum: {sum}");
  Console.WriteLine("\n--------------------\n");
}

Console.WriteLine("All values have been added.");
Console.WriteLine($"Final sum: {sum}");
