namespace FilamentFinalProject
{
    partial class Credits
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
            this.BtnToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtInfo1
            // 
            this.TxtInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtInfo1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtInfo1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInfo1.ForeColor = System.Drawing.Color.LimeGreen;
            this.TxtInfo1.Location = new System.Drawing.Point(25, 29);
            this.TxtInfo1.Name = "TxtInfo1";
            this.TxtInfo1.Size = new System.Drawing.Size(421, 19);
            this.TxtInfo1.TabIndex = 0;
            this.TxtInfo1.TabStop = false;
            this.TxtInfo1.Text = "All game elements created by Emily Kolar.";
            // 
            // BtnToMenu
            // 
            this.BtnToMenu.BackColor = System.Drawing.Color.Green;
            this.BtnToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnToMenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnToMenu.Location = new System.Drawing.Point(25, 72);
            this.BtnToMenu.Name = "BtnToMenu";
            this.BtnToMenu.Size = new System.Drawing.Size(200, 55);
            this.BtnToMenu.TabIndex = 0;
            this.BtnToMenu.TabStop = false;
            this.BtnToMenu.Text = "Back to Menu";
            this.BtnToMenu.UseVisualStyleBackColor = false;
            this.BtnToMenu.Click += new System.EventHandler(this.BtnToMenu_Click);
            // 
            // Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.BtnToMenu);
            this.Controls.Add(this.TxtInfo1);
            this.Name = "Credits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtInfo1;
        private System.Windows.Forms.Button BtnToMenu;
    }
}