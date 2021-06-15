using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoodColorDemo
{
    public partial class Form1 : Form
    {
        MoodColor moodColor = new MoodColor(200, -2, 100, 3, 0, 5);
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BackColor = moodColor.Color;
            this.Invalidate();
        }
    }
}
