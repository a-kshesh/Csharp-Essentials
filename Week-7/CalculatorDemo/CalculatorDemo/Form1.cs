using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorDemo
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Label1_Click(object sender, EventArgs e)
        {
           
        }

        private void DigitalHandler(object sender, EventArgs e)
        {
            Button button = sender as Button;
            txtOutput.Text = txtOutput.Text + button.Text;
        }

        private void btnChangeSign_Click(object sender, EventArgs e)
        {
            string firstLetter = txtOutput.Text.Substring(0,1);
            if (firstLetter == "-")
            {
                txtOutput.Text = txtOutput.Text.Substring(1, txtOutput.Text.Length-1);
            }
            else
            {
                string s = "-" + txtOutput.Text;
                //MessageBox.Show(s);
                txtOutput.Text = s;
            }
        }

        private void TxtOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
