using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Form f = new Form();
            Button b = new Button();
            b.Text="Click me";
            b.Click += ClickHandler;
            b.Click += (object sender, EventArgs e) => MessageBox.Show("Power of lambda ");
            f.Controls.Add(b);


            Application.Run(f);

        }

        private static void ClickHandler(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }
    }
}
