using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionCalculatorDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Fraction fraction = new Fraction();
        private void Keypressed( object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                return;
            else e.Handled = true;
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
                   }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void PerformAction_Click(object sender, EventArgs e)
        {
            Fraction fraction1 = new Fraction(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            Fraction fraction2 = new Fraction(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            Fraction result = new Fraction();

            if (radioButton1.Checked)
            {
                result = fraction1 + fraction2;
            }
            else if (radioButton2.Checked)
            {
                 result = fraction1 - fraction2;
            }
            else if (radioButton3.Checked)
            {
                 result = fraction1 * fraction2;
            }
            else if (radioButton4.Checked)
            {
                 result = fraction1 / fraction2;
            }

            else
            {
                MessageBox.Show("Please select Operation");
            }

            textBox6.Text = result.Top.ToString();
            textBox5.Text = result.Bottom.ToString();

        }
    }
}
