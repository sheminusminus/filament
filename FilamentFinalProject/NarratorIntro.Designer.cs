namespace FilamentFinalProject
{
    partial class NarratorIntro
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
            System.Windows.Forms.Button BtnOtherQ;
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BtnWhereQ = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            BtnOtherQ = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOtherQ
            // 
            BtnOtherQ.BackColor = System.Drawing.Color.ForestGreen;
            BtnOtherQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnOtherQ.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BtnOtherQ.Location = new System.Drawing.Point(15, 68);
            BtnOtherQ.Name = "BtnOtherQ";
            BtnOtherQ.Size = new System.Drawing.Size(230, 55);
            BtnOtherQ.TabIndex = 1;
            BtnOtherQ.TabStop = false;
            BtnOtherQ.Text = "\"Where did things go wrong?\"";
            BtnOtherQ.UseVisualStyleBackColor = false;
            BtnOtherQ.Click += new System.EventHandler(this.BtnOtherQ_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(533, 49);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "You must be pretty confused, but don\'t freak out just yet.";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBox2.Location = new System.Drawing.Point(12, 76);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(521, 66);
            this.textBox2.TabIndex = 1;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "I\'ve been written into the program to try and guide you back to safety.";
            // 
            // BtnWhereQ
            // 
            this.BtnWhereQ.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnWhereQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWhereQ.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWhereQ.Location = new System.Drawing.Point(15, 17);
            this.BtnWhereQ.Name = "BtnWhereQ";
            this.BtnWhereQ.Size = new System.Drawing.Size(230, 55);
            this.BtnWhereQ.TabIndex = 0;
            this.BtnWhereQ.TabStop = false;
            this.BtnWhereQ.Text = "\"... Where am I?\"";
            this.BtnWhereQ.UseVisualStyleBackColor = false;
            this.BtnWhereQ.Click += new System.EventHandler(this.BtnWhereQ_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.BtnWhereQ);
            this.panel1.Controls.Add(BtnOtherQ);
            this.panel1.Location = new System.Drawing.Point(15, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 140);
            this.panel1.TabIndex = 2;
            // 
            // NarratorIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "NarratorIntro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NarratorIntro";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BtnWhereQ;
        private System.Windows.Forms.Panel panel1;
    }
}