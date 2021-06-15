using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    public class Expense
    {
        public static int EXPENSE_ID_SEQ = 0;
        public string Description { get; }
        public string Place { get; }
        public int Id { get; }
        public double Amount { get; }
        public DateTime Date { get; }

        public Expense(int id, string name,string description, double value,DateTime date)
        {
            Id = id;
            Place = name;
            Description = description;
            Amount = value;
            Date = date;
        }

        public static List<Expense> GetExpenses()
        {
            return new List<Expense>()
            {
                new Expense(EXPENSE_ID_SEQ++,"Walmart","Grocery",54.4,new DateTime(2019,11,22)),
                new Expense(EXPENSE_ID_SEQ++,"Walmart","Grocery",12.4,new DateTime(2019,11,29)),
                new Expense(EXPENSE_ID_SEQ++,"Best Buy","iPhone",1150.71,new DateTime(2019,11,27)),
                new Expense(EXPENSE_ID_SEQ++,"Chatr","Monthly Bill",45.00,new DateTime(2019,11,01)),
                new Expense(EXPENSE_ID_SEQ++,"TTC","Bus pass",122.00,new DateTime(2019,11,01)),
                new Expense(EXPENSE_ID_SEQ++,"Tim Hortons","Breakfast",7.30,new DateTime(2019,11,15)),
                new Expense(EXPENSE_ID_SEQ++,"Shoppers Drug Mart","Medicines",67.89,new DateTime(2019,11,18)),
                new Expense(EXPENSE_ID_SEQ++,"Centennial College","Print Pay",1.21,new DateTime(2019,11,25)),
                new Expense(EXPENSE_ID_SEQ++,"Mac Donalds","Lunch",12.40,new DateTime(2019,11,10))
            };
        }
        
    }
}
