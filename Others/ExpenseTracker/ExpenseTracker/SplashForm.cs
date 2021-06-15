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
    public partial class SplashForm : Form
    {
        int counter = 10;
        public SplashForm()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if(counter < 0)
            {
                this.Close();
            }
        }
    }
}
