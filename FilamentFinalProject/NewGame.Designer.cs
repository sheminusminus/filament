namespace FilamentFinalProject
{
    partial class NewGame
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
            this.TxtInfo1 = new System.Windows.Forms.TextBox();
            this.TxtInfo2 = new System.Windows.Forms.TextBox();
            this.TxtInfo3 = new System.Windows.Forms.TextBox();
            this.BtnWhat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtInfo1
            // 
            this.TxtInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtInfo1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtInfo1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInfo1.ForeColor = System.Drawing.Color.LimeGreen;
            this.TxtInfo1.Location = new System.Drawing.Point(15, 18);
            this.TxtInfo1.Multiline = true;
            this.TxtInfo1.Name = "TxtInfo1";
            this.TxtInfo1.Size = new System.Drawing.Size(520, 69);
            this.TxtInfo1.TabIndex = 0;
            this.TxtInfo1.TabStop = false;
            this.TxtInfo1.Text = "Hello there... I hate to be the bearer of bad news, but there\'s been sort of a mi" +
    "shap.";
            // 
            // TxtInfo2
            // 
            this.TxtInfo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtInfo2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtInfo2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInfo2.ForeColor = System.Drawing.Color.LimeGreen;
            this.TxtInfo2.Location = new System.Drawing.Point(15, 79);
            this.TxtInfo2.Multiline = true;
            this.TxtInfo2.Name = "TxtInfo2";
            this.TxtInfo2.Size = new System.Drawing.Size(520, 20);
            this.TxtInfo2.TabIndex = 1;
            this.TxtInfo2.TabStop = false;
            this.TxtInfo2.Text = "The project had a bug. And it was... Major.";
            // 
            // TxtInfo3
            // 
            this.TxtInfo3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtInfo3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtInfo3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInfo3.ForeColor = System.Drawing.Color.LimeGreen;
            this.TxtInfo3.Location = new System.Drawing.Point(15, 119);
            this.TxtInfo3.Multiline = true;
            this.TxtInfo3.Name = "TxtInfo3";
            this.TxtInfo3.Size = new System.Drawing.Size(520, 72);
            this.TxtInfo3.TabIndex = 2;
            this.TxtInfo3.TabStop = false;
            this.TxtInfo3.Text = "No one was able to catch it before they fired up the machine, and by then it was " +
    "too late. You were already wired in.";
            // 
            // BtnWhat
            // 
            this.BtnWhat.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnWhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWhat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWhat.ForeColor = System.Drawing.Color.Black;
            this.BtnWhat.Location = new System.Drawing.Point(15, 16);
            this.BtnWhat.Name = "BtnWhat";
            this.BtnWhat.Size = new System.Drawing.Size(230, 55);
            this.BtnWhat.TabIndex = 0;
            this.BtnWhat.TabStop = false;
            this.BtnWhat.Text = "\"... What?\"";
            this.BtnWhat.UseVisualStyleBackColor = false;
            this.BtnWhat.Click += new System.EventHandler(this.BtnWhat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.BtnWhat);
            this.panel1.Location = new System.Drawing.Point(15, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 86);
            this.panel1.TabIndex = 3;
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtInfo3);
            this.Controls.Add(this.TxtInfo2);
            this.Controls.Add(this.TxtInfo1);
            this.Name = "NewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filament: Game";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtInfo1;
        private System.Windows.Forms.TextBox TxtInfo2;
        private System.Windows.Forms.TextBox TxtInfo3;
        private System.Windows.Forms.Button BtnWhat;
        private System.Windows.Forms.Panel panel1;
    }
}