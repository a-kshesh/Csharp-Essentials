namespace MayorDemo
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.endOfficeBox = new System.Windows.Forms.TextBox();
            this.startOfficeBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mayorGrid = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mayorGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(52, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(480, 366);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.endOfficeBox);
            this.tabPage1.Controls.Add(this.startOfficeBox);
            this.tabPage1.Controls.Add(this.nameBox);
            this.tabPage1.Controls.Add(this.addButton);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(472, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add a New Mayor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // endOfficeBox
            // 
            this.endOfficeBox.Location = new System.Drawing.Point(125, 143);
            this.endOfficeBox.Name = "endOfficeBox";
            this.endOfficeBox.Size = new System.Drawing.Size(227, 22);
            this.endOfficeBox.TabIndex = 7;
            // 
            // startOfficeBox
            // 
            this.startOfficeBox.Location = new System.Drawing.Point(125, 90);
            this.startOfficeBox.Name = "startOfficeBox";
            this.startOfficeBox.Size = new System.Drawing.Size(227, 22);
            this.startOfficeBox.TabIndex = 6;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(125, 32);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(227, 22);
            this.nameBox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(242, 249);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 43);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addMayor);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "End of Office:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start of Office:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mayorGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(472, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "All the Mayors";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mayorGrid
            // 
            this.mayorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mayorGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mayorGrid.Location = new System.Drawing.Point(3, 3);
            this.mayorGrid.Name = "mayorGrid";
            this.mayorGrid.RowHeadersWidth = 51;
            this.mayorGrid.RowTemplate.Height = 24;
            this.mayorGrid.Size = new System.Drawing.Size(466, 331);
            this.mayorGrid.TabIndex = 0;
            this.mayorGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MayorGrid_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mayorGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox endOfficeBox;
        private System.Windows.Forms.TextBox startOfficeBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.DataGridView mayorGrid;
    }
}

