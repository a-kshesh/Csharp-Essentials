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
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            SplashForm();
        }

        private void SplashForm()
        {
            SplashForm splashForm = new SplashForm();
            splashForm.ShowDialog();
        }
    }

   
}
