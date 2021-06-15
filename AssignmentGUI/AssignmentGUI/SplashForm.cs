using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentGUI
{
    public partial class SplashForm : Form
    {
        int timer = 25;
        public SplashForm()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer--;
            if (timer == 0)
            {
                this.Close();
                ;
            }
        }
    }
}
