// Exercise013 - Highest and Lowest Price
// Write a program that reads the prices of 8 products
// and determines the highest and lowest values entered.

int count = 0;
decimal highestPrice = decimal.MinValue;
decimal lowestPrice = decimal.MaxValue;

while (count < 8)
{
  Console.Write($"Enter price #{count + 1}: ");
  decimal userInput = Convert.ToDecimal(Console.ReadLine());

  if (userInput > highestPrice)
    highestPrice = userInput;

  if (userInput < lowestPrice)
    lowestPrice = userInput;

  count++;

  Console.WriteLine("\n--------------------\n");
}

Console.WriteLine($"Highest price: {highestPrice:C}");
Console.WriteLine($"Lowest price: {lowestPrice:C}");
