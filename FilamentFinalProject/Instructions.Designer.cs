namespace FilamentFinalProject
{
    partial class Instructions
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
            this.BtnToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtInfo1
            // 
            this.TxtInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtInfo1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtInfo1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInfo1.ForeColor = System.Drawing.Color.LimeGreen;
            this.TxtInfo1.Location = new System.Drawing.Point(13, 13);
            this.TxtInfo1.Multiline = true;
            this.TxtInfo1.Name = "TxtInfo1";
            this.TxtInfo1.Size = new System.Drawing.Size(474, 33);
            this.TxtInfo1.TabIndex = 0;
            this.TxtInfo1.TabStop = false;
            this.TxtInfo1.Text = "Read the text, which will provide the story. ";
            // 
            // TxtInfo2
            // 
            this.TxtInfo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtInfo2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtInfo2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInfo2.ForeColor = System.Drawing.Color.LimeGreen;
            this.TxtInfo2.Location = new System.Drawing.Point(13, 55);
            this.TxtInfo2.Multiline = true;
            this.TxtInfo2.Name = "TxtInfo2";
            this.TxtInfo2.Size = new System.Drawing.Size(450, 29);
            this.TxtInfo2.TabIndex = 1;
            this.TxtInfo2.TabStop = false;
            this.TxtInfo2.Text = "Choose an option when prompted.";
            // 
            // TxtInfo3
            // 
            this.TxtInfo3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtInfo3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtInfo3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInfo3.ForeColor = System.Drawing.Color.LimeGreen;
            this.TxtInfo3.Location = new System.Drawing.Point(13, 96);
            this.TxtInfo3.Name = "TxtInfo3";
            this.TxtInfo3.Size = new System.Drawing.Size(474, 19);
            this.TxtInfo3.TabIndex = 2;
            this.TxtInfo3.TabStop = false;
            this.TxtInfo3.Text = "Complete the challenges and have fun!";
            // 
            // BtnToMenu
            // 
            this.BtnToMenu.BackColor = System.Drawing.Color.Green;
            this.BtnToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnToMenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnToMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnToMenu.Location = new System.Drawing.Point(13, 147);
            this.BtnToMenu.Name = "BtnToMenu";
            this.BtnToMenu.Size = new System.Drawing.Size(200, 55);
            this.BtnToMenu.TabIndex = 0;
            this.BtnToMenu.TabStop = false;
            this.BtnToMenu.Text = "Back To Menu";
            this.BtnToMenu.UseVisualStyleBackColor = false;
            this.BtnToMenu.Click += new System.EventHandler(this.BtnToMenu_Click);
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.BtnToMenu);
            this.Controls.Add(this.TxtInfo3);
            this.Controls.Add(this.TxtInfo2);
            this.Controls.Add(this.TxtInfo1);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Green;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Instructions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instructions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtInfo1;
        private System.Windows.Forms.TextBox TxtInfo2;
        private System.Windows.Forms.TextBox TxtInfo3;
        private System.Windows.Forms.Button BtnToMenu;
    }
}