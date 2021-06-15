namespace StudentTracker
{
    partial class FormAddStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.tkbarSemester = new System.Windows.Forms.TrackBar();
            this.chkIsDomestic = new System.Windows.Forms.CheckBox();
            this.txtGpa = new System.Windows.Forms.TextBox();
            this.cboProgramCode = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbarSemester)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSemester, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnOk, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtFName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tkbarSemester, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkIsDomestic, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtGpa, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cboProgramCode, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 193);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lastname";
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(3, 54);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(68, 17);
            this.lblSemester.TabIndex = 2;
            this.lblSemester.Text = "Semester";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gpa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Domestic student";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Program Code";
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(3, 164);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(218, 27);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOk.Location = new System.Drawing.Point(227, 164);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(218, 27);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(227, 2);
            this.txtFName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(89, 22);
            this.txtFName.TabIndex = 8;
            this.txtFName.Text = "Parwinder";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(227, 29);
            this.txtLName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(89, 22);
            this.txtLName.TabIndex = 9;
            this.txtLName.Text = "Kaur";
            // 
            // tkbarSemester
            // 
            this.tkbarSemester.Location = new System.Drawing.Point(227, 56);
            this.tkbarSemester.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tkbarSemester.Maximum = 8;
            this.tkbarSemester.Minimum = 1;
            this.tkbarSemester.Name = "tkbarSemester";
            this.tkbarSemester.Size = new System.Drawing.Size(218, 23);
            this.tkbarSemester.TabIndex = 10;
            this.tkbarSemester.Value = 1;
            this.tkbarSemester.Scroll += new System.EventHandler(this.tkbarSemester_Scroll);
            // 
            // chkIsDomestic
            // 
            this.chkIsDomestic.AutoSize = true;
            this.chkIsDomestic.Location = new System.Drawing.Point(227, 110);
            this.chkIsDomestic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkIsDomestic.Name = "chkIsDomestic";
            this.chkIsDomestic.Size = new System.Drawing.Size(18, 17);
            this.chkIsDomestic.TabIndex = 11;
            this.chkIsDomestic.UseVisualStyleBackColor = true;
            // 
            // txtGpa
            // 
            this.txtGpa.Location = new System.Drawing.Point(227, 83);
            this.txtGpa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGpa.Name = "txtGpa";
            this.txtGpa.Size = new System.Drawing.Size(89, 22);
            this.txtGpa.TabIndex = 12;
            this.txtGpa.Text = "3.4";
            // 
            // cboProgramCode
            // 
            this.cboProgramCode.FormattingEnabled = true;
            this.cboProgramCode.Location = new System.Drawing.Point(227, 137);
            this.cboProgramCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboProgramCode.Name = "cboProgramCode";
            this.cboProgramCode.Size = new System.Drawing.Size(108, 24);
            this.cboProgramCode.TabIndex = 13;
            // 
            // FormAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 193);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddStudent";
            this.Text = "FormAddStudent";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbarSemester)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TrackBar tkbarSemester;
        private System.Windows.Forms.CheckBox chkIsDomestic;
        private System.Windows.Forms.TextBox txtGpa;
        private System.Windows.Forms.ComboBox cboProgramCode;
    }
}