// Exercise008 - Travel Fare Calculation
// Write a program that reads the distance a passenger wants to travel in 
// kilometers and calculates the ticket price, charging R$0.50 per km for 
// trips up to 200 km and R$0.45 per km for longer trips.

Console.Write("Enter the distance you wish to travel (in kilometers): ");
int travelDistance = Convert.ToInt32(Console.ReadLine());

decimal travelRate;

if (travelDistance > 200)
  travelRate = 0.45M;
else 
  travelRate = 0.50M;

decimal totalPrice = travelDistance * travelRate;

Console.WriteLine($"The rate applied is {travelRate:C} per kilometer.");
Console.WriteLine($"Total ticket price: {totalPrice:C}");
