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
        MoodColor moodColorDemo = new MoodColor(200, 2, 150, 5, 150, 6);
        public Form1()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.BackColor = moodColorDemo.Color;
            this.Invalidate();
        }
    }
}

        
