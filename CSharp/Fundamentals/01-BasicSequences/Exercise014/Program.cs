// Exercise014 - Car Rental Cost Calculation
// Write a program that reads the number of kilometers driven and the number of 
// rental days, then calculates the total price to pay, considering a cost of 
// R$90 per day and R$0.20 per kilometer.

Console.Write("Enter the kilometers driven: ");
decimal kilometersDriven = Convert.ToDecimal(Console.ReadLine());

Console.Write("Enter the number of rental days: ");
int rentalDays = Convert.ToInt32(Console.ReadLine());

decimal totalPrice = rentalDays * 90 + kilometersDriven * 0.20M;

Console.WriteLine($"Total price to pay: {totalPrice:C}");
