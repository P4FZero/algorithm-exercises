// Exercise001 - Speeding Fine Calculation
// Write a program that reads the speed of a car and checks if it exceeds 
// 80 km/h. If so, display a fine calculated at R$5 for each km/h above the 
// speed limit.

Console.Write("Please enter the car speed (km/h): ");
int carSpeed = Convert.ToInt32(Console.ReadLine());

if (carSpeed > 80)
{
  decimal fineAmount = (carSpeed - 80) * 5;
  Console.WriteLine($"You exceeded the speed limit. A fine of {fineAmount:C} has been issued.");
}
else
{
  Console.WriteLine("Good news! You did not exceed the speed limit. No fine will be issued.");
}
