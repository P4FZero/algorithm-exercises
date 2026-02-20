// Exercise015 - Monthly Salary Based on Workdays
// Write a program that reads the number of days worked in a month
// and calculates the employee's salary, considering 8 working hours per day
// and R$25 earned per hour.

Console.Write("Days worked in a month: ");
int daysWorked = Convert.ToInt32(Console.ReadLine());

decimal employeeSalary = daysWorked * 8 * 25;

Console.WriteLine($"Employee's salary: {employeeSalary:C}");
