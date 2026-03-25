// Exercise004 - Countdown by Step with While Loop
// Write a program that displays numbers from 100 down to 0,
// decreasing by 5 each time, using a while loop,
// followed by the message "Finished!".

int count = 100;

while (count >= 0)
{
  Console.WriteLine(count);
  count -= 5;
}

Console.WriteLine("Finished!");
