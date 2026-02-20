// Exercise003 - Employee Salary Message
// Write a program that reads an employee's name and salary
// and displays a formatted message with this information.

Console.Write("Employee's name: ");
string employeeName = Console.ReadLine();

Console.Write("Salary: ");
decimal employeeSalary = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"The employee {employeeName} has a salary of {employeeSalary:C} in June");
