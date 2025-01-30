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

            }





        }
    }
}
