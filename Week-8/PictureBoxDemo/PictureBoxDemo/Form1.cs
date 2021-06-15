using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxDemo
{
    public partial class Form1 : Form
    {
        List<Premier> premiers = new List<Premier>(Premier.GetPremiers());
        Dictionary<string, Premier> dict = new Dictionary<string, Premier>();
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < premiers.Count; i++)
            {
                listBox1.Items.Add(premiers[i].GetKey());
                dict.Add(premiers[i].GetKey(), premiers[i]);
            }
          
        }

         
        
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void infoShow(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = listBox1.SelectedItem.ToString()+".jpg";
            label1.Text = dict[listBox1.SelectedItem.ToString()].name;
            label2.Text = dict[listBox1.SelectedItem.ToString()].range + dict[listBox1.SelectedItem.ToString()].party;
        }
    }
}