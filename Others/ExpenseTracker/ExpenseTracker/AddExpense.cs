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
    public partial class AddExpense : Form
    {
        Form1 mainForm = new Form1();
        public AddExpense(Form1 f)
        {
            mainForm = f;
            InitializeComponent();
            cbcPlace.DataSource = new List<string>() {"Walmart","TTC","Shoppers Durg","Best Buy"};
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            mainForm.expenses.Add(new Expense(Expense.EXPENSE_ID_SEQ++,cbcPlace.Text,txtDescription.Text,Convert.ToDouble(txtAmount.Text),dtpDate.Value));
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
