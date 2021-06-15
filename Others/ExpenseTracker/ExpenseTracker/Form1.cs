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
    public partial class Form1 : Form
    {

        public List<Expense> expenses = Expense.GetExpenses();

        public Form1()
        {
            InitializeComponent();
            SplashForm();
        }

        

        void SplashForm()
        {
            SplashForm form = new SplashForm();
            form.ShowDialog();
            //(Show() can give liberty to users to access another window
            //whereas showDialog() cannot as another form can only run after closing it)

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddExpense f = new AddExpense(this);
            f.Show();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            ViewExpense f = new ViewExpense(this);
            f.Show();
        }

    }
}
