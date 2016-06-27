namespace FilamentFinalProject
{
    partial class PickItem
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
            this.PbItem = new System.Windows.Forms.PictureBox();
            this.PbAbility = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.BtnYesItem = new System.Windows.Forms.Button();
            this.BtnYesAbility = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.BtnFuschia = new System.Windows.Forms.Button();
            this.BtnPeri = new System.Windows.Forms.Button();
            this.BtnMar = new System.Windows.Forms.Button();
            this.BtnContinue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAbility)).BeginInit();
            this.SuspendLayout();
            // 
            // PbItem
            // 
            this.PbItem.Location = new System.Drawing.Point(74, 85);
            this.PbItem.Name = "PbItem";
            this.PbItem.Size = new System.Drawing.Size(75, 75);
            this.PbItem.TabIndex = 0;
            this.PbItem.TabStop = false;
            this.PbItem.Click += new System.EventHandler(this.PbItem_Click);
            // 
            // PbAbility
            // 
            this.PbAbility.Location = new System.Drawing.Point(434, 85);
            this.PbAbility.Name = "PbAbility";
            this.PbAbility.Size = new System.Drawing.Size(75, 75);
            this.PbAbility.TabIndex = 1;
            this.PbAbility.TabStop = false;
            this.PbAbility.Click += new System.EventHandler(this.PbAbility_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.Location = new System.Drawing.Point(12, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(556, 58);
            this.textBox1.TabIndex = 2;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "You can pick either an item or an ability to help you out along the way.";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Silver;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(380, 19);
            this.textBox2.TabIndex = 3;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "I almost forgot!";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Silver;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(74, 178);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 39);
            this.textBox3.TabIndex = 4;
            this.textBox3.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Silver;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(434, 178);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(75, 39);
            this.textBox4.TabIndex = 5;
            this.textBox4.TabStop = false;
            // 
            // BtnYesItem
            // 
            this.BtnYesItem.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnYesItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnYesItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnYesItem.Location = new System.Drawing.Point(223, 128);
            this.BtnYesItem.Name = "BtnYesItem";
            this.BtnYesItem.Size = new System.Drawing.Size(145, 55);
            this.BtnYesItem.TabIndex = 6;
            this.BtnYesItem.TabStop = false;
            this.BtnYesItem.Text = "I have chosen!";
            this.BtnYesItem.UseVisualStyleBackColor = false;
            this.BtnYesItem.Visible = false;
            this.BtnYesItem.Click += new System.EventHandler(this.BtnYesItem_Click);
            // 
            // BtnYesAbility
            // 
            this.BtnYesAbility.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnYesAbility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnYesAbility.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnYesAbility.Location = new System.Drawing.Point(223, 128);
            this.BtnYesAbility.Name = "BtnYesAbility";
            this.BtnYesAbility.Size = new System.Drawing.Size(145, 55);
            this.BtnYesAbility.TabIndex = 7;
            this.BtnYesAbility.TabStop = false;
            this.BtnYesAbility.Text = "I have chosen!";
            this.BtnYesAbility.UseVisualStyleBackColor = false;
            this.BtnYesAbility.Visible = false;
            this.BtnYesAbility.Click += new System.EventHandler(this.BtnYesAbility_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Silver;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(5, 250);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(556, 19);
            this.textBox5.TabIndex = 8;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "What color would you like that in?";
            this.textBox5.Visible = false;
            // 
            // BtnFuschia
            // 
            this.BtnFuschia.BackColor = System.Drawing.Color.Fuchsia;
            this.BtnFuschia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFuschia.Location = new System.Drawing.Point(74, 284);
            this.BtnFuschia.Name = "BtnFuschia";
            this.BtnFuschia.Size = new System.Drawing.Size(75, 75);
            this.BtnFuschia.TabIndex = 9;
            this.BtnFuschia.TabStop = false;
            this.BtnFuschia.UseVisualStyleBackColor = false;
            this.BtnFuschia.Visible = false;
            this.BtnFuschia.Click += new System.EventHandler(this.BtnFuschia_Click);
            // 
            // BtnPeri
            // 
            this.BtnPeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.BtnPeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPeri.Location = new System.Drawing.Point(252, 284);
            this.BtnPeri.Name = "BtnPeri";
            this.BtnPeri.Size = new System.Drawing.Size(75, 75);
            this.BtnPeri.TabIndex = 10;
            this.BtnPeri.TabStop = false;
            this.BtnPeri.UseVisualStyleBackColor = false;
            this.BtnPeri.Visible = false;
            this.BtnPeri.Click += new System.EventHandler(this.BtnPeri_Click);
            // 
            // BtnMar
            // 
            this.BtnMar.BackColor = System.Drawing.Color.Maroon;
            this.BtnMar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMar.Location = new System.Drawing.Point(434, 284);
            this.BtnMar.Name = "BtnMar";
            this.BtnMar.Size = new System.Drawing.Size(75, 75);
            this.BtnMar.TabIndex = 11;
            this.BtnMar.TabStop = false;
            this.BtnMar.UseVisualStyleBackColor = false;
            this.BtnMar.Visible = false;
            this.BtnMar.Click += new System.EventHandler(this.BtnMar_Click);
            // 
            // BtnContinue
            // 
            this.BtnContinue.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContinue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContinue.Location = new System.Drawing.Point(223, 386);
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.Size = new System.Drawing.Size(145, 55);
            this.BtnContinue.TabIndex = 12;
            this.BtnContinue.TabStop = false;
            this.BtnContinue.Text = "Back to Map";
            this.BtnContinue.UseVisualStyleBackColor = false;
            this.BtnContinue.Visible = false;
            this.BtnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // PickItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.BtnContinue);
            this.Controls.Add(this.BtnMar);
            this.Controls.Add(this.BtnPeri);
            this.Controls.Add(this.BtnFuschia);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.BtnYesAbility);
            this.Controls.Add(this.BtnYesItem);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.PbAbility);
            this.Controls.Add(this.PbItem);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "PickItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "One More Thing!";
            ((System.ComponentModel.ISupportInitialize)(this.PbItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAbility)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbItem;
        private System.Windows.Forms.PictureBox PbAbility;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button BtnYesItem;
        private System.Windows.Forms.Button BtnYesAbility;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button BtnFuschia;
        private System.Windows.Forms.Button BtnPeri;
        private System.Windows.Forms.Button BtnMar;
        private System.Windows.Forms.Button BtnContinue;
    }
}