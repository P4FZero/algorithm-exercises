// Exercise012 - Promotional Price with Discount
// Write a program that reads the price of a product and calculates its 
// promotional price with a 5% discount.

Console.Write("Product price: ");
decimal productPrice = Convert.ToDecimal(Console.ReadLine());

decimal promotionalPrice = productPrice - productPrice * 0.05M;

Console.WriteLine($"Product promotional price: {promotionalPrice:c}");
