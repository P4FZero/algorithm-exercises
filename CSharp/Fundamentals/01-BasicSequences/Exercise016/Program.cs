// Exercise016 - Smoking Life Reduction Challenge
// Write a program that calculates the reduction in a smoker's lifespan.
// The program should read the number of cigarettes smoked per day and
// the number of years the person has smoked, considering that each
// cigarette reduces life expectancy by 10 minutes, and display the
// total life reduction in days.

Console.Write("Number of cigarettes smoked per day: ");
int cigarettesPerDay = Convert.ToInt32(Console.ReadLine());

Console.Write("Number of years smoking: ");
int yearsSmoking = Convert.ToInt32(Console.ReadLine());

long totalCigarettes = cigarettesPerDay * yearsSmoking * 365;
long totalLifeReductionInDays = totalCigarettes * 10 / 1440;

Console.WriteLine($"Total life reduction in days: {totalLifeReductionInDays} days");
