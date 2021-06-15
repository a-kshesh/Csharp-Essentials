using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayorDemo
{
    public partial class Form1 : Form
    {
        List<Mayor> mayorList = new List<Mayor>(Mayor.GetMayors());
        public Form1()
        {
            InitializeComponent();
           
           
            
        }

        private void MayorGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addMayor(object sender, MouseEventArgs e)
        {
            Mayor mayor = new Mayor(nameBox.Text, startOfficeBox.Text, endOfficeBox.Text);
            mayorList.Add(mayor);
            mayorGrid.DataSource = mayorList;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            nameBox.Clear();
            startOfficeBox.Clear();
            endOfficeBox.Clear();
        }
    }
}
