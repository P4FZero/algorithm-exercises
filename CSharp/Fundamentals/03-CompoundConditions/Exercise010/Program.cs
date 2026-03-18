// Exercise010 - Car Rental Pricing by Category
// Write a program that reads the type of car rented (popular or luxury),
// the number of rental days, and the kilometers driven. Calculate the
// total price based on daily rates and distance rates, which vary
// according to the car category and distance traveled.

Console.WriteLine("Car Rental Pricing System\n");
Console.WriteLine("[1] - Popular car");
Console.WriteLine("[2] - Luxury car");
Console.Write("Select the car category: ");
int carCategory = Convert.ToInt32(Console.ReadLine());
string carCategoryString = carCategory == 1 ? "Popular" : "Luxury";

Console.Write("\nEnter the number of rental days: ");
int rentalDays = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the number of kilometers driven: ");
int kilometers = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine("Rental Information Summary");
Console.WriteLine($"Car category: {carCategoryString}");
Console.WriteLine($"Rental days: {rentalDays}");
Console.WriteLine($"Kilometers driven: {kilometers} kilometers\n");

Console.WriteLine("Calculating the total rental price...\n");

decimal dailyRate;
decimal distanceRate;

if (carCategory == 1)
{
  dailyRate = 90M;
  distanceRate = kilometers <= 100 ? 0.20M : 0.10M;
}
else
{
  dailyRate = 150M;
  distanceRate = kilometers <= 200 ? 0.30M : 0.25M;
}

decimal dailyCost = dailyRate * rentalDays;
decimal distanceCost = distanceRate * kilometers;
decimal totalPrice = dailyCost + distanceCost;

Console.WriteLine($"Daily cost: {dailyCost:C}");
Console.WriteLine($"Distance cost: {distanceCost:C}");
Console.WriteLine($"Total rental price: {totalPrice:C}");
