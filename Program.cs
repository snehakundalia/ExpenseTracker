
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Expense e = new Expense();
            int choice = 0;
            do
            {
                Console.WriteLine("Enter your choice : \n1. For adding expense\n2. For displaying expense\n3. For getting total expense\n4. Stop");
                try
                {
                    choice = Convert.ToInt16(Console.Read());
                    switch(choice)
                    {
                        case 1:
                            e.addExpense();
                            break;
                        case 2:
                            e.displayExpense();
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                    }
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.ToString());
                }
            } while (choice != 4);
        }
    }

    class Expense
    {
        int expenseId;
        string category;
        double amount;
        string paymentMode;
        DateTime expenseDate;

        public void addExpense()
        {
            Console.WriteLine("================================");
            Console.WriteLine("        Expense Tracker         ");
            Console.WriteLine("================================");
            Console.WriteLine("Enter your expense Id : ");
            expenseId = Convert.ToInt16(Console.Read());
            if(amount <= 0)
            {
                Console.WriteLine("Invalid amount entered");
            }
        }

        public void displayExpense()
        {
            if(amount == 0)
            {
                Console.WriteLine("You have no expense!");
            }
        }
    }
}
