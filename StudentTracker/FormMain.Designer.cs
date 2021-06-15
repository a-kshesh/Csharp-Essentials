namespace StudentTracker
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgrdStudents = new System.Windows.Forms.DataGridView();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboQueries = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgrdStudents, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteStudent, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAddStudent, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboQueries, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(553, 292);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgrdStudents
            // 
            this.dgrdStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgrdStudents, 2);
            this.dgrdStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrdStudents.Location = new System.Drawing.Point(3, 31);
            this.dgrdStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrdStudents.Name = "dgrdStudents";
            this.dgrdStudents.RowHeadersWidth = 51;
            this.dgrdStudents.RowTemplate.Height = 28;
            this.dgrdStudents.Size = new System.Drawing.Size(547, 230);
            this.dgrdStudents.TabIndex = 0;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteStudent.Location = new System.Drawing.Point(3, 265);
            this.btnDeleteStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(270, 25);
            this.btnDeleteStudent.TabIndex = 1;
            this.btnDeleteStudent.Text = "Delete a Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddStudent.Location = new System.Drawing.Point(279, 265);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(271, 25);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "Add new Button";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select a filter";
            // 
            // cboQueries
            // 
            this.cboQueries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboQueries.FormattingEnabled = true;
            this.cboQueries.Location = new System.Drawing.Point(279, 2);
            this.cboQueries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboQueries.Name = "cboQueries";
            this.cboQueries.Size = new System.Drawing.Size(271, 24);
            this.cboQueries.TabIndex = 4;
            this.cboQueries.SelectedIndexChanged += new System.EventHandler(this.cboQueries_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 292);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgrdStudents;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboQueries;
    }
}

