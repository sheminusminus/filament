namespace FilamentFinalProject
{
    partial class StartScreen
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
            this.BtnNewGame = new System.Windows.Forms.Button();
            this.BtnInstruct = new System.Windows.Forms.Button();
            this.BtnCredits = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtPlayerName = new System.Windows.Forms.TextBox();
            this.TxtRequestName = new System.Windows.Forms.TextBox();
            this.BtnLetsGo = new System.Windows.Forms.Button();
            this.PB_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNewGame
            // 
            this.BtnNewGame.BackColor = System.Drawing.Color.Green;
            this.BtnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewGame.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewGame.Location = new System.Drawing.Point(148, 151);
            this.BtnNewGame.Name = "BtnNewGame";
            this.BtnNewGame.Size = new System.Drawing.Size(150, 55);
            this.BtnNewGame.TabIndex = 1;
            this.BtnNewGame.TabStop = false;
            this.BtnNewGame.Text = "New Game";
            this.BtnNewGame.UseVisualStyleBackColor = false;
            this.BtnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // BtnInstruct
            // 
            this.BtnInstruct.BackColor = System.Drawing.Color.Green;
            this.BtnInstruct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInstruct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInstruct.Location = new System.Drawing.Point(297, 151);
            this.BtnInstruct.Name = "BtnInstruct";
            this.BtnInstruct.Size = new System.Drawing.Size(150, 55);
            this.BtnInstruct.TabIndex = 2;
            this.BtnInstruct.TabStop = false;
            this.BtnInstruct.Text = "Instructions";
            this.BtnInstruct.UseVisualStyleBackColor = false;
            this.BtnInstruct.Click += new System.EventHandler(this.BtnInstruct_Click);
            // 
            // BtnCredits
            // 
            this.BtnCredits.BackColor = System.Drawing.Color.Green;
            this.BtnCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCredits.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCredits.Location = new System.Drawing.Point(148, 205);
            this.BtnCredits.Name = "BtnCredits";
            this.BtnCredits.Size = new System.Drawing.Size(150, 55);
            this.BtnCredits.TabIndex = 3;
            this.BtnCredits.TabStop = false;
            this.BtnCredits.Text = "Credits";
            this.BtnCredits.UseVisualStyleBackColor = false;
            this.BtnCredits.Click += new System.EventHandler(this.BtnCredits_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Green;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(297, 205);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(150, 55);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.TabStop = false;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 5;
            // 
            // TxtPlayerName
            // 
            this.TxtPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPlayerName.Location = new System.Drawing.Point(148, 314);
            this.TxtPlayerName.Name = "TxtPlayerName";
            this.TxtPlayerName.Size = new System.Drawing.Size(299, 20);
            this.TxtPlayerName.TabIndex = 0;
            this.TxtPlayerName.Visible = false;
            this.TxtPlayerName.TextChanged += new System.EventHandler(this.TxtPlayerName_TextChanged);
            // 
            // TxtRequestName
            // 
            this.TxtRequestName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtRequestName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtRequestName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRequestName.ForeColor = System.Drawing.Color.White;
            this.TxtRequestName.Location = new System.Drawing.Point(148, 289);
            this.TxtRequestName.Name = "TxtRequestName";
            this.TxtRequestName.Size = new System.Drawing.Size(299, 19);
            this.TxtRequestName.TabIndex = 7;
            this.TxtRequestName.TabStop = false;
            this.TxtRequestName.Text = "Please enter your name to continue:";
            this.TxtRequestName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtRequestName.Visible = false;
            // 
            // BtnLetsGo
            // 
            this.BtnLetsGo.BackColor = System.Drawing.Color.Green;
            this.BtnLetsGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLetsGo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLetsGo.Location = new System.Drawing.Point(257, 340);
            this.BtnLetsGo.Name = "BtnLetsGo";
            this.BtnLetsGo.Size = new System.Drawing.Size(83, 45);
            this.BtnLetsGo.TabIndex = 2;
            this.BtnLetsGo.Text = "Let\'s Go";
            this.BtnLetsGo.UseVisualStyleBackColor = false;
            this.BtnLetsGo.Visible = false;
            this.BtnLetsGo.Click += new System.EventHandler(this.BtnLetsGo_Click);
            // 
            // PB_Logo
            // 
            this.PB_Logo.Image = global::FilamentFinalProject.Properties.Resources.FilamentRed11;
            this.PB_Logo.Location = new System.Drawing.Point(78, 12);
            this.PB_Logo.Name = "PB_Logo";
            this.PB_Logo.Size = new System.Drawing.Size(450, 120);
            this.PB_Logo.TabIndex = 8;
            this.PB_Logo.TabStop = false;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.PB_Logo);
            this.Controls.Add(this.BtnLetsGo);
            this.Controls.Add(this.TxtRequestName);
            this.Controls.Add(this.TxtPlayerName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnCredits);
            this.Controls.Add(this.BtnInstruct);
            this.Controls.Add(this.BtnNewGame);
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filament: Welcome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartScreen_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNewGame;
        private System.Windows.Forms.Button BtnInstruct;
        private System.Windows.Forms.Button BtnCredits;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtPlayerName;
        private System.Windows.Forms.TextBox TxtRequestName;
        private System.Windows.Forms.Button BtnLetsGo;
        private System.Windows.Forms.PictureBox PB_Logo;
    }
}

