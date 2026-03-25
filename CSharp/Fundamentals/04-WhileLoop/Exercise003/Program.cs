// Exercise003 - Counting by Step with While Loop
// Write a program that displays numbers from 0 to 18,
// increasing by 3 each time, using a while loop,
// followed by the message "Finished!".

int count = 0;

while (count <= 18)
{
  Console.WriteLine(count);
  count += 3;
}

Console.WriteLine("Finished!");
