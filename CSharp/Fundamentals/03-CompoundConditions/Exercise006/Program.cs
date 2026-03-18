// Exercise006 - Rock Paper Scissors Game Challenge
// Create a Rock-Paper-Scissors (JoKenPo) game where the user
// chooses between rock, paper, or scissors and the program
// determines the result based on the game rules.

Console.WriteLine("Welcome to the Rock, Paper, Scissors!");
Console.WriteLine("Choose your move and try to beat the computer.\n");

Console.WriteLine("[1] - Rock");
Console.WriteLine("[2] - Paper");
Console.WriteLine("[3] - Scissors");
Console.Write("Enter your choice: ");
int playerChoice = Convert.ToInt32(Console.ReadLine());

Random random = new Random();
int computerChoice = random.Next(1, 4);

Console.Clear();
Console.WriteLine("Rock... Paper... Scissors... Shoot!\n");
Console.WriteLine($"You chose: {ChoiceName(playerChoice)}");
Console.WriteLine($"The computer chose: {ChoiceName(computerChoice)}\n");

if (playerChoice == computerChoice)
{
  Console.WriteLine("It's a tie!");
  return;
}

bool isPlayerWin =
  (playerChoice == 1 && computerChoice == 3) ||
  (playerChoice == 2 && computerChoice == 1) ||
  (playerChoice == 3 && computerChoice == 2);

if (isPlayerWin)
  Console.WriteLine("Congratulations! You win!");
else
  Console.WriteLine("The computer wins! Better luck next time.");

static string ChoiceName(int choiceId)
{
  return choiceId switch
  {
    1 => "Rock",
    2 => "Paper",
    3 => "Scissors",
    _ => "Invalid choice"
  };
}
