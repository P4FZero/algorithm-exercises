// Exercise002 - Countdown with While Loop
// Write a program that displays a countdown from 10 to 3
// using a while loop, followed by the message "Finished!".

int count = 10;

while (count >= 3)
{
  Console.WriteLine(count--);
}

Console.WriteLine("Finished!");
