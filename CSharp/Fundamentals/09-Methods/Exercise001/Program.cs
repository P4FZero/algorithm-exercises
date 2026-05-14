// Exercise001 - Hello World Method
// Write a program that creates a method named Generator()
// which displays the message "Hello, World!"
// surrounded by decorative lines.

Generator("Hello, World!", 5, 1);

static string CreateBorder(int style, int size)
{
  return style switch
  {
    1 => $"+{new string('-', size)}+",
    2 => $"~{new string(':', size)}~",
    3 => $"<{new string('-', size)}>",
    _ => ""
  };
}

static void Generator(string message, int numberOfMessages, int borderStyle)
{
  if (numberOfMessages <= 0)
  {
    WriteColored("Invalid number of repetitions.", ConsoleColor.Red);
    return;
  }

  if (borderStyle < 1 || borderStyle > 3)
  {
    WriteColored("Invalid border style.", ConsoleColor.Red);
    return;
  }

  string border = CreateBorder(borderStyle, message.Length + 2);

  WriteColored(border, ConsoleColor.Cyan);

  for (int index = 0; index < numberOfMessages; index++)
  {
    WriteColored($"| {message} |", ConsoleColor.Blue);
  }

  WriteColored(border, ConsoleColor.Cyan);
}

static void WriteColored(string message, ConsoleColor color)
{
  Console.ForegroundColor = color;
  Console.WriteLine(message);
  Console.ResetColor();
}
