using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class ViewExpense : Form
    {
        Form1 mainForm;
        

        public ViewExpense(Form1 f)
        {
            InitializeComponent();
            mainForm = f;
            dgrdExpense.DataSource = mainForm.expenses;
            cbcQueries.DataSource = new List<string>() {
                "All Expenses",
                "Today's Expenses",
                "Walmart's Expenses",
                "Amount > 100"
            };
        }

        private void CbcQueries_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbcQueries.Text)
            {
                case "All Expenses":
                    dgrdExpense.DataSource = null;
                    dgrdExpense.DataSource = mainForm.expenses;
                    break;

                case "Today's Expenses":
                    DateTime startDateTime = DateTime.Today;
                    DateTime endDateTime = DateTime.Today.AddDays(1).AddTicks(-1);
                    var r = mainForm.expenses.Where(a => a.Date >= startDateTime && a.Date <= endDateTime);
                    dgrdExpense.DataSource = r.ToList();
                    break;

                case "Walmart's Expenses":
                    var r1 = mainForm.expenses.Where(a => a.Place == "Walmart");
                    dgrdExpense.DataSource = r1.ToList();
                    break;

                case "Amount > 100":
                    var r2 = mainForm.expenses.Where(b => b.Amount > 100);
                    dgrdExpense.DataSource = r2.ToList();
                    break;
            }
        }
    }
}
