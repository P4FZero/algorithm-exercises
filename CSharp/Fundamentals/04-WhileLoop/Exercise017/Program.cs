// Exercise017 - Number Guessing Game with Attempts (Challenge)
// Improve the previous guessing game by generating a random number
// between 1 and 10 and giving the player 4 attempts to guess it.

Console.WriteLine("Welcome to the Number Guessing Game!");
Console.WriteLine("I am thinking of a number between 1 and 10.");
Console.WriteLine("You have 4 attempts. Can you guess which number it is?\n");

int playerAttempts = 4;
Random random = new Random();
int computerNumber = random.Next(1, 11);

while (playerAttempts > 0)
{
  Console.Write("Enter your guess (1 to 10): ");
  int playerGuess = Convert.ToInt32(Console.ReadLine());

  if (playerGuess == computerNumber)
  {
    Console.WriteLine("Congratulations! You guessed the correct number!");
    break;
  }

  if (playerGuess < computerNumber)
    Console.WriteLine("Too low!");
  else
    Console.WriteLine("Too high!");

  playerAttempts--;
  Console.WriteLine($"Attempts remaining: {playerAttempts}\n");
}

if (playerAttempts == 0)
  Console.WriteLine($"Game over! The correct number was {computerNumber}");
