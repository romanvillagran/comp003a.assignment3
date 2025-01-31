// Author: Roman
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Budget management application demonstrating control flow.
namespace comp003a.assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double monthlyIncome = 0;
            string[] expenses = new string[5];
            double[] expenseAmount = new double[5];
            int count = 0;

            Console.Write("Enter your monthly budget:");
            monthlyIncome = double.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("\n1. Add an Expense");
                Console.WriteLine("2. View expenses and budget");
                Console.WriteLine("3. Remove and expense");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Choose and option");
                int choice = Convert.ToInt32(Console.ReadLine()); // converts the users input into a int

                switch (choice)
                {
                    case 1:
                        if (count >= 5)
                        {
                            Console.WriteLine("you can only add up to 5 expenses.");
                            break;
                        }

                        Console.Write("Enter expense name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter the amount of the expense: ");
                        double amount = Convert.ToDouble(Console.ReadLine());// converts the users input into a double

                        expenses[count] = name;
                        expenseAmount[count] = amount;
                        count++;

                        Console.WriteLine("Expense added");
                        break;

                    case 2:
                        {
                            double totalExpenses = 0; 
                            Console.WriteLine("\nExpenses: ");
                            for (int i = 0; i < count; i++)
                            {
                                Console.WriteLine($"{expenses[i]}: ${expenseAmount[i]}");
                                totalExpenses += expenseAmount[i];
                            }
                            double whateverIsLeft = monthlyIncome - totalExpenses;
                            Console.WriteLine($"\n Total Expenses: ${totalExpenses}");
                            Console.WriteLine($"\n Remaining Budget: ${whateverIsLeft}");
                            break;

                        }

                }

            }





        }
    }
}
