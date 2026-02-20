// Exercise009 - Currency Conversion (BRL to USD)
// Write a program that reads the amount of money a person has
// in Brazilian reais (R$) and displays how many US dollars
// can be purchased, considering the exchange rate US$1.00 = R$3.45.

Console.Write("Amount (R$): ");
decimal totalBRL = Convert.ToDecimal(Console.ReadLine());

decimal totalUSD = totalBRL / 3.45M;

Console.WriteLine($"Amount (US$): {totalUSD:F2}");
