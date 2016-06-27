namespace FilamentFinalProject
{
    partial class Reddit
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
            this.Floor = new System.Windows.Forms.Panel();
            this.TinyPants = new System.Windows.Forms.PictureBox();
            this.TinyShirt = new System.Windows.Forms.PictureBox();
            this.TinyFace = new System.Windows.Forms.PictureBox();
            this.TinyHead = new System.Windows.Forms.PictureBox();
            this.arrowsPending = new System.Windows.Forms.Label();
            this.goldPending = new System.Windows.Forms.Label();
            this.Arrows = new System.Windows.Forms.PictureBox();
            this.PbAlien = new System.Windows.Forms.PictureBox();
            this.GoldEscape = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.Floor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TinyPants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TinyShirt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TinyFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TinyHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAlien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoldEscape)).BeginInit();
            this.SuspendLayout();
            // 
            // Floor
            // 
            this.Floor.BackColor = System.Drawing.Color.Transparent;
            this.Floor.BackgroundImage = global::FilamentFinalProject.Properties.Resources.redMap5;
            this.Floor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Floor.Controls.Add(this.TinyPants);
            this.Floor.Controls.Add(this.TinyShirt);
            this.Floor.Controls.Add(this.TinyFace);
            this.Floor.Controls.Add(this.TinyHead);
            this.Floor.Controls.Add(this.arrowsPending);
            this.Floor.Controls.Add(this.goldPending);
            this.Floor.Controls.Add(this.Arrows);
            this.Floor.Controls.Add(this.PbAlien);
            this.Floor.Controls.Add(this.GoldEscape);
            this.Floor.Location = new System.Drawing.Point(-1, -1);
            this.Floor.Name = "Floor";
            this.Floor.Size = new System.Drawing.Size(477, 465);
            this.Floor.TabIndex = 0;
            this.Floor.Paint += new System.Windows.Forms.PaintEventHandler(this.Floor_Paint);
            // 
            // TinyPants
            // 
            this.TinyPants.Location = new System.Drawing.Point(299, 364);
            this.TinyPants.Name = "TinyPants";
            this.TinyPants.Size = new System.Drawing.Size(35, 20);
            this.TinyPants.TabIndex = 6;
            this.TinyPants.TabStop = false;
            // 
            // TinyShirt
            // 
            this.TinyShirt.Location = new System.Drawing.Point(299, 349);
            this.TinyShirt.Name = "TinyShirt";
            this.TinyShirt.Size = new System.Drawing.Size(35, 35);
            this.TinyShirt.TabIndex = 5;
            this.TinyShirt.TabStop = false;
            // 
            // TinyFace
            // 
            this.TinyFace.BackColor = System.Drawing.Color.Peru;
            this.TinyFace.Location = new System.Drawing.Point(309, 333);
            this.TinyFace.Name = "TinyFace";
            this.TinyFace.Size = new System.Drawing.Size(15, 17);
            this.TinyFace.TabIndex = 4;
            this.TinyFace.TabStop = false;
            // 
            // TinyHead
            // 
            this.TinyHead.Location = new System.Drawing.Point(304, 325);
            this.TinyHead.Name = "TinyHead";
            this.TinyHead.Size = new System.Drawing.Size(25, 25);
            this.TinyHead.TabIndex = 3;
            this.TinyHead.TabStop = false;
            // 
            // arrowsPending
            // 
            this.arrowsPending.AutoSize = true;
            this.arrowsPending.BackColor = System.Drawing.Color.Goldenrod;
            this.arrowsPending.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrowsPending.ForeColor = System.Drawing.Color.Black;
            this.arrowsPending.Location = new System.Drawing.Point(24, 393);
            this.arrowsPending.Name = "arrowsPending";
            this.arrowsPending.Size = new System.Drawing.Size(80, 22);
            this.arrowsPending.TabIndex = 11;
            this.arrowsPending.Text = "LOCKED";
            // 
            // goldPending
            // 
            this.goldPending.AutoSize = true;
            this.goldPending.BackColor = System.Drawing.Color.Goldenrod;
            this.goldPending.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goldPending.ForeColor = System.Drawing.Color.Black;
            this.goldPending.Location = new System.Drawing.Point(13, 41);
            this.goldPending.Name = "goldPending";
            this.goldPending.Size = new System.Drawing.Size(80, 22);
            this.goldPending.TabIndex = 7;
            this.goldPending.Text = "LOCKED";
            // 
            // Arrows
            // 
            this.Arrows.Location = new System.Drawing.Point(0, 349);
            this.Arrows.Name = "Arrows";
            this.Arrows.Size = new System.Drawing.Size(113, 116);
            this.Arrows.TabIndex = 2;
            this.Arrows.TabStop = false;
            // 
            // PbAlien
            // 
            this.PbAlien.Location = new System.Drawing.Point(360, 155);
            this.PbAlien.Name = "PbAlien";
            this.PbAlien.Size = new System.Drawing.Size(70, 77);
            this.PbAlien.TabIndex = 1;
            this.PbAlien.TabStop = false;
            // 
            // GoldEscape
            // 
            this.GoldEscape.Location = new System.Drawing.Point(0, 3);
            this.GoldEscape.Name = "GoldEscape";
            this.GoldEscape.Size = new System.Drawing.Size(84, 75);
            this.GoldEscape.TabIndex = 0;
            this.GoldEscape.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Reddit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(659, 462);
            this.Controls.Add(this.Floor);
            this.Name = "Reddit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reddit";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Reddit_KeyDown);
            this.Floor.ResumeLayout(false);
            this.Floor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TinyPants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TinyShirt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TinyFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TinyHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAlien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoldEscape)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Floor;
        private System.Windows.Forms.PictureBox PbAlien;
        private System.Windows.Forms.PictureBox GoldEscape;
        private System.Windows.Forms.PictureBox TinyPants;
        private System.Windows.Forms.PictureBox TinyShirt;
        private System.Windows.Forms.PictureBox TinyFace;
        private System.Windows.Forms.PictureBox TinyHead;
        private System.Windows.Forms.PictureBox Arrows;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label goldPending;
        private System.Windows.Forms.Label arrowsPending;
    }
}