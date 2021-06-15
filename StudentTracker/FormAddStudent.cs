using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTracker
{
    public partial class FormAddStudent : Form
    {
        FormMain formMain;
        public FormAddStudent(FormMain form)
        {
            InitializeComponent();
            InitGui();
            formMain = form;
        }
        void InitGui()
        {
            cboProgramCode.DataSource = new List<String>()
            { "3408", "3529","3428" };
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"{txtFName.Text} {txtLName.Text} ({tkbarSemester.Value}) gpa:{txtGpa.Text} \n{cboProgramCode.Text} {(chkIsDomestic.Checked ? "Domestic" : "International")}");
            Student student = new Student
                (
                    txtFName.Text, txtLName.Text,
                    cboProgramCode.Text, tkbarSemester.Value, Convert.ToDouble(txtGpa.Text),
                    chkIsDomestic.Checked
                );
            formMain.AddStudent(student);
        }

        private void tkbarSemester_Scroll(object sender, EventArgs e)
        {
            lblSemester.Text = $"Semester ({tkbarSemester.Value})";
        }
    }
}
