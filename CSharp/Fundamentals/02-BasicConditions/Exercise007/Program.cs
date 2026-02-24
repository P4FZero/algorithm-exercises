// Exercise007 - Gender-Based Discount Calculation
// Write a program that reads a customer's name, gender, and purchase amount,
// then calculates the final price applying a 5% discount for men
// and a 13% discount for women.

Console.Write("Enter the customer's name: ");
string customerName = Console.ReadLine();

Console.Write("Enter the customer's gender (M/F): ");
char customerGender = Convert.ToChar(Console.ReadLine().ToUpper()[0]);

Console.Write("Enter the purchase amount: ");
decimal purchaseAmount = Convert.ToDecimal(Console.ReadLine());

decimal discountRate;

if (customerGender.Equals('M'))
  discountRate = 0.05M;
else if (customerGender.Equals('F'))
  discountRate = 0.13M;
else
{
  Console.WriteLine("Invalid gender input.");
  return;
}

decimal discountAmount = purchaseAmount * discountRate;
decimal finalPrice = purchaseAmount - discountAmount;

Console.WriteLine($"A {discountRate:P0} discount has been applied.");
Console.WriteLine($"Discount amount: {discountAmount:C}.");
Console.WriteLine($"Final price: {finalPrice:C}.");
