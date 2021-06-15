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
    public partial class FormMain : Form
    {
        List<Student> students = Student.GetStudents();
        public FormMain()
        {
            InitializeComponent();
            InitGui();
        }
        void InitGui()
        {
            dgrdStudents.DataSource = students;
            //FormSplash form = new FormSplash();
            //form.ShowDialog();
            cboQueries.DataSource = new List<string>() { "All Students", "All Domestic Students" };
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            FormAddStudent form = new FormAddStudent(this);
            form.Show();
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
            dgrdStudents.DataSource = null;
            dgrdStudents.DataSource = students;
        }

        private void cboQueries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboQueries.Text == "All Domestic Students")
            {
                var stud = students.Where(s => s.IsDomestic).OrderBy(s => s.Gpa);
                dgrdStudents.DataSource = stud.ToList();
            }
            if (cboQueries.Text == "All Students")
            {
                dgrdStudents.DataSource = students;
            }
        }
    }
}
