namespace FilamentFinalProject
{
    partial class Narrator3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BtnMention = new System.Windows.Forms.Button();
            this.BtnSoWhat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.textBox1.Size = new System.Drawing.Size(509, 32);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Haven\'t you noticed the way your limbs feel?";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBox2.Location = new System.Drawing.Point(13, 73);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(509, 61);
            this.textBox2.TabIndex = 1;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Or maybe it slipped past you that although you can somehow see, you don\'t have ey" +
    "es anymore.";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBox3.Location = new System.Drawing.Point(12, 31);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(479, 36);
            this.textBox3.TabIndex = 2;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Sort of like they\'re made out of tv static?";
            // 
            // BtnMention
            // 
            this.BtnMention.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnMention.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMention.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMention.Location = new System.Drawing.Point(14, 16);
            this.BtnMention.Name = "BtnMention";
            this.BtnMention.Size = new System.Drawing.Size(230, 55);
            this.BtnMention.TabIndex = 3;
            this.BtnMention.TabStop = false;
            this.BtnMention.Text = "\"Now that you mention it...\"";
            this.BtnMention.UseVisualStyleBackColor = false;
            this.BtnMention.Click += new System.EventHandler(this.BtnMention_Click);
            // 
            // BtnSoWhat
            // 
            this.BtnSoWhat.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnSoWhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSoWhat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSoWhat.Location = new System.Drawing.Point(14, 70);
            this.BtnSoWhat.Name = "BtnSoWhat";
            this.BtnSoWhat.Size = new System.Drawing.Size(230, 55);
            this.BtnSoWhat.TabIndex = 4;
            this.BtnSoWhat.TabStop = false;
            this.BtnSoWhat.Text = "\"So, what now?\"";
            this.BtnSoWhat.UseVisualStyleBackColor = false;
            this.BtnSoWhat.Click += new System.EventHandler(this.BtnSoWhat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.BtnSoWhat);
            this.panel1.Controls.Add(this.BtnMention);
            this.panel1.Location = new System.Drawing.Point(15, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 140);
            this.panel1.TabIndex = 5;
            // 
            // Narrator3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Narrator3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Narrator3";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button BtnMention;
        private System.Windows.Forms.Button BtnSoWhat;
        private System.Windows.Forms.Panel panel1;
    }
}