// Exercise011 - Healthy Activity Rewards Program
// Write a program that reads the number of hours of physical activity
// performed in a month, calculates the points earned based on defined
// hourly ranges, and determines how much money the person earns,
// considering that each point is worth R$0.05.

Console.WriteLine("Healthy Activity Rewards Program\n");

Console.Write("Enter the total number of hours of physical activity performed this month: ");
int totalHours = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine("Calculating your reward points and earnings...");

int totalPoints = totalHours switch
{
  <= 10 => totalHours * 2,
  <= 20 => totalHours * 5,
  _ => totalHours * 10,
};

decimal pointsPrice = 0.05M;
decimal totalAmount = totalPoints * pointsPrice;

Console.WriteLine($"Total hours of activity: {totalHours} hour(s).");
Console.WriteLine($"Points earned: {totalPoints}.");
Console.WriteLine($"Total amount earned: {totalAmount:C}");
