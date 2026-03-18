// Exercise007 - Number Guessing Game Challenge
// Create a game where the computer randomly generates a number
// between 1 and 5, and the player must guess which number was chosen.

Console.WriteLine("Welcome to the Number Guessing Game!");
Console.WriteLine("I am thinking of a number between 1 and 5.");
Console.WriteLine("Can you guess which number it is?\n");

Console.Write("Enter your guess (1 to 5): ");
int playerGuess = Convert.ToInt32(Console.ReadLine());

Random random = new();
int computerNumber = random.Next(1, 6);

Console.WriteLine("\nLet me check your guess...");
Console.WriteLine($"The number chosen was: {computerNumber}.\n");

if (playerGuess == computerNumber)
  Console.WriteLine("Congratulations! You guessed the correct number!");
else
  Console.WriteLine("Sorry. Better luck next time!");
