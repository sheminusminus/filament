namespace FilamentFinalProject
{
    partial class Challenge2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Challenge2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.UserDice1 = new System.Windows.Forms.Panel();
            this.UserDice2 = new System.Windows.Forms.Panel();
            this.EnemyDice1 = new System.Windows.Forms.Panel();
            this.EnemyDice2 = new System.Windows.Forms.Panel();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::FilamentFinalProject.Properties.Resources.tabletop2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(-9, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(591, 377);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "diceOne1.png");
            this.imageList1.Images.SetKeyName(1, "diceTwo.png");
            this.imageList1.Images.SetKeyName(2, "dice_three.png");
            this.imageList1.Images.SetKeyName(3, "diceFour.png");
            this.imageList1.Images.SetKeyName(4, "diceFive.png");
            this.imageList1.Images.SetKeyName(5, "diceSixPink.png");
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(5, 333);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 34);
            this.button3.TabIndex = 6;
            this.button3.Text = "Roll Dice";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(42)))), ((int)(((byte)(2)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(215, 204);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 46);
            this.textBox1.TabIndex = 7;
            // 
            // UserDice1
            // 
            this.UserDice1.BackColor = System.Drawing.Color.Transparent;
            this.UserDice1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserDice1.Location = new System.Drawing.Point(202, 204);
            this.UserDice1.Name = "UserDice1";
            this.UserDice1.Size = new System.Drawing.Size(60, 60);
            this.UserDice1.TabIndex = 8;
            this.UserDice1.Visible = false;
            // 
            // UserDice2
            // 
            this.UserDice2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserDice2.Location = new System.Drawing.Point(305, 204);
            this.UserDice2.Name = "UserDice2";
            this.UserDice2.Size = new System.Drawing.Size(60, 60);
            this.UserDice2.TabIndex = 9;
            this.UserDice2.Visible = false;
            // 
            // EnemyDice1
            // 
            this.EnemyDice1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EnemyDice1.Location = new System.Drawing.Point(202, 116);
            this.EnemyDice1.Name = "EnemyDice1";
            this.EnemyDice1.Size = new System.Drawing.Size(60, 60);
            this.EnemyDice1.TabIndex = 10;
            this.EnemyDice1.Visible = false;
            // 
            // EnemyDice2
            // 
            this.EnemyDice2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EnemyDice2.Location = new System.Drawing.Point(305, 116);
            this.EnemyDice2.Name = "EnemyDice2";
            this.EnemyDice2.Size = new System.Drawing.Size(60, 60);
            this.EnemyDice2.TabIndex = 11;
            this.EnemyDice2.Visible = false;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "blackdice.png");
            this.imageList2.Images.SetKeyName(1, "blackdice2.png");
            this.imageList2.Images.SetKeyName(2, "blackdice3.png");
            this.imageList2.Images.SetKeyName(3, "blackdice4.png");
            this.imageList2.Images.SetKeyName(4, "blackdice5.png");
            this.imageList2.Images.SetKeyName(5, "blackdice6.png");
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.SeaShell;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(192, 283);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 29);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.SeaShell;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(295, 283);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(80, 29);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.SeaShell;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(192, 68);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(80, 29);
            this.textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.SeaShell;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(295, 68);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(80, 29);
            this.textBox5.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(235, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "You Win!";
            this.label1.Visible = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(470, 329);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 38);
            this.button4.TabIndex = 18;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGreen;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(186, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nice. One more roll!";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(108, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 27);
            this.label3.TabIndex = 20;
            this.label3.Text = "Final challenge: A game of dice!";
            // 
            // Challenge2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(585, 378);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.EnemyDice2);
            this.Controls.Add(this.EnemyDice1);
            this.Controls.Add(this.UserDice2);
            this.Controls.Add(this.UserDice1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Challenge2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Challenge2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel UserDice1;
        private System.Windows.Forms.Panel UserDice2;
        private System.Windows.Forms.Panel EnemyDice1;
        private System.Windows.Forms.Panel EnemyDice2;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}