// Exercise001 - Counting with Do-While Loop
// Write a program that displays numbers from 0 to 30,
// increasing by 3 each time, using a do-while loop,
// followed by the message "Finished!".

Console.WriteLine("Displaying numbers from 0 to 30, increasing by 3...\n");

int count = 0;

do
{
  Console.WriteLine(count);
  count += 3;
} while (count <= 30);

Console.WriteLine("Finished!");
