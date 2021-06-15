using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


            private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (char.IsDigit(e.KeyChar))
                {
                    return;
                }
                else e.Handled = true;
            }


            private void Button1_Click(object sender, EventArgs e)
            {
                Fraction left = new Fraction(Convert.ToInt32(leftTop.Text), Convert.ToInt32(leftBottom.Text));
                Fraction right = new Fraction(Convert.ToInt32(rightTop.Text), Convert.ToInt32(rightBottom.Text));

                Fraction result = new Fraction();

                char sign = '+';

                // checks which radio button is being selected
                if (radioButton1.Checked)
                {
                    sign = '+';
                }

                else if (radioButton2.Checked)
                {
                    sign = '-';
                }

                else if (radioButton3.Checked)
                {
                    sign = '*';
                }

                else if (radioButton5.Checked)
                {
                    sign = '/';
                }

                // operates as per the selected sign
                switch (sign)
                {
                    case '+':
                        result = left + right;
                        break;

                    case '-':
                        result = left - right;
                        break;

                    case '*':
                        result = left * right;
                        break;

                    case '/':
                        result = left / right;
                        break;

                }

                //sets the resulted values to the text box
                resultTop.Text = result.Top.ToString();
                resultBottom.Text = result.Bottom.ToString();
            }

            private void Label2_Click(object sender, EventArgs e)
            {

            }

            private void Label3_Click(object sender, EventArgs e)
            {

            }

            private void Label4_Click(object sender, EventArgs e)
            {

            }

            private void LeftTop_TextChanged(object sender, EventArgs e)
            {

            }

            private void LeftBottom_TextChanged(object sender, EventArgs e)
            {

            }

            private void RightBottom_TextChanged(object sender, EventArgs e)
            {

            }

            private void RightTop_TextChanged(object sender, EventArgs e)
            {

            }

            private void Label5_Click(object sender, EventArgs e)
            {

            }

            private void ResultBottom_TextChanged(object sender, EventArgs e)
            {

            }

            private void ResultTop_TextChanged(object sender, EventArgs e)
            {

            }

            private void Label6_Click(object sender, EventArgs e)
            {

            }

            private void Panel1_Paint(object sender, PaintEventArgs e)
            {

            }

            private void RadioButton5_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void RadioButton3_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void RadioButton2_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void RadioButton1_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void Label1_Click(object sender, EventArgs e)
            {

            }

            private void Label7_Click(object sender, EventArgs e)
            {

            }
        
    }
}
