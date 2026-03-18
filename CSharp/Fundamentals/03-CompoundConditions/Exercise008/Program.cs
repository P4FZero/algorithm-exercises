// Exercise008 - Home Loan Approval
// Write a program that reads the house price, the buyer's salary,
// and the number of years to pay. Calculate the monthly payment
// and determine whether the loan should be approved, considering
// that the installment cannot exceed 30% of the buyer's salary.

Console.Write("Enter the price of the house: ");
decimal housePrice = Convert.ToDecimal(Console.ReadLine());

Console.Write("Enter the buyer's monthly salary: ");
decimal buyerSalary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Enter the number of years to repay the loan: ");
int yearsToRepay = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine("Calculating the monthly payment and evaluating loan approval...\n");

int totalMonths = yearsToRepay * 12;
decimal monthlyPayment = housePrice / totalMonths;
decimal salaryCap = buyerSalary * 0.3M;

Console.WriteLine($"House price: {housePrice:C}");
Console.WriteLine($"Loan term: {yearsToRepay} years");
Console.WriteLine($"Monthly payment: {monthlyPayment:C}");
Console.WriteLine($"30% of your salary: {salaryCap:C}\n");

if (monthlyPayment <= salaryCap)
  Console.WriteLine("Congratulations! Your loan has been approved.");
else
  Console.WriteLine("Unfortunately, the monthly payment exceeds 30% of your salary. The loan cannot be approved.");
