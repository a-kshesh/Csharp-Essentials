namespace RPNCalculatorDemo
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
            this.expressionCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // expressionCB
            // 
            this.expressionCB.FormattingEnabled = true;
            this.expressionCB.Location = new System.Drawing.Point(110, 162);
            this.expressionCB.Name = "expressionCB";
            this.expressionCB.Size = new System.Drawing.Size(296, 24);
            this.expressionCB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(472, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ans";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(116, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Expression";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(445, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "Answer";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(421, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expressionCB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox expressionCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

