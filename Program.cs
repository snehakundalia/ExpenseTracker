using System;
using System.Collections.Generic; using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
internal class Program
{
class Expense
{
public int ExpenseID; public string category; public double Amout;
public String paymentMode; public DateTime ExpenseDate; public void Addexpense()
{
Console.Write("Enter the Expense ID:");
ExpenseID = Convert.ToInt32(Console.ReadLine()); Console.Write("Enter the category :");
category = Console.ReadLine(); Console.Write("Enter the Amount :");
Amout = Convert.ToInt32(Console.ReadLine()); if (Amout <= 0)
{
throw new Exception("Not a valid Amount");
}
Console.Write("Enter the payment MOde(UPI/Cash/Card) : "); paymentMode = Console.ReadLine();
ExpenseDate = DateTime.Now;


}
public void DisplayExpense()
{
Console.WriteLine("========================================");
Console.WriteLine("Displaying Details."); Console.WriteLine("========================================");
Console.WriteLine("Expense ID :" + ExpenseID); Console.WriteLine("Category :" + category); Console.WriteLine("Amount :" + Amout); Console.WriteLine("Payment Mode :" + paymentMode); Console.WriteLine("Expense Date " + ExpenseDate.ToString());

}
}
 

static void Main(string[] args)
{
List<Expense> n = new List<Expense>(); int choice = 0;

do
{
Console.WriteLine("============================================");
Console.WriteLine("Expense Tracking Module"); Console.WriteLine("============================================");
Console.WriteLine("1. Add Expense"); Console.WriteLine("2. View All Expenses"); Console.WriteLine("3. View Total Expense"); Console.WriteLine("4. Exit"); Console.Write("Enter your choice: ");

try
{
choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
case 1: try
{
Expense e = new Expense(); e.Addexpense();
n.Add(e);
Console.WriteLine("Expense Added Successfully.");
}
catch (Exception ex)
{
Console.WriteLine("Error: " + ex.Message);
}
break;

case 2:
if (n.Count == 0)
{
Console.WriteLine("No expenses found.");
}
else
{
Console.WriteLine("\nAll Expenses:"); foreach (Expense e in n)
{
e.DisplayExpense();
}
}
break; case 3:
 
double total = 0;

foreach (Expense e in n)
{
total += e.Amout;
}

Console.WriteLine("==================================");
Console.WriteLine("Total Expense = " + total); Console.WriteLine("==================================");
break;

case 4:
Console.WriteLine("Thank You!"); break;

default:
Console.WriteLine("Invalid Choice."); break;
}
}
catch (FormatException)
{
Console.WriteLine("Please enter only numeric values.");
}
catch (Exception ex)
{
Console.WriteLine("Error: " + ex.Message);
}
} while (choice != 4);
}
}
}
