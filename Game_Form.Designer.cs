namespace Our_Tic_Tac
{
    partial class Game_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_Form));
            this.Tour = new System.Windows.Forms.Label();
            this.Joueur_Tour = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.J1_nom = new System.Windows.Forms.Label();
            this.J2_nom = new System.Windows.Forms.Label();
            this.J1_score = new System.Windows.Forms.Label();
            this.J2_score = new System.Windows.Forms.Label();
            this.Partie = new System.Windows.Forms.Label();
            this.Num_partie = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_WOC3 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC4 = new ePOSOne.btnProduct.Button_WOC();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tour
            // 
            this.Tour.BackColor = System.Drawing.Color.RoyalBlue;
            this.Tour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tour.Location = new System.Drawing.Point(499, 91);
            this.Tour.Name = "Tour";
            this.Tour.Size = new System.Drawing.Size(164, 28);
            this.Tour.TabIndex = 3;
            this.Tour.Text = "Player Tour";
            this.Tour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Joueur_Tour
            // 
            this.Joueur_Tour.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Joueur_Tour.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Joueur_Tour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Joueur_Tour.Location = new System.Drawing.Point(499, 128);
            this.Joueur_Tour.Name = "Joueur_Tour";
            this.Joueur_Tour.Size = new System.Drawing.Size(164, 33);
            this.Joueur_Tour.TabIndex = 4;
            this.Joueur_Tour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Joueur_Tour.Click += new System.EventHandler(this.Joueur_Tour_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.RoyalBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(499, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Score";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // J1_nom
            // 
            this.J1_nom.BackColor = System.Drawing.Color.CornflowerBlue;
            this.J1_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.J1_nom.ForeColor = System.Drawing.Color.Black;
            this.J1_nom.Location = new System.Drawing.Point(499, 208);
            this.J1_nom.Name = "J1_nom";
            this.J1_nom.Size = new System.Drawing.Size(79, 21);
            this.J1_nom.TabIndex = 6;
            this.J1_nom.Text = "Joueur1";
            this.J1_nom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // J2_nom
            // 
            this.J2_nom.BackColor = System.Drawing.Color.CornflowerBlue;
            this.J2_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.J2_nom.Location = new System.Drawing.Point(584, 208);
            this.J2_nom.Name = "J2_nom";
            this.J2_nom.Size = new System.Drawing.Size(79, 21);
            this.J2_nom.TabIndex = 7;
            this.J2_nom.Text = "Joueur2";
            this.J2_nom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // J1_score
            // 
            this.J1_score.BackColor = System.Drawing.Color.Aquamarine;
            this.J1_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.J1_score.ForeColor = System.Drawing.Color.Black;
            this.J1_score.Location = new System.Drawing.Point(497, 307);
            this.J1_score.Name = "J1_score";
            this.J1_score.Size = new System.Drawing.Size(81, 48);
            this.J1_score.TabIndex = 8;
            this.J1_score.Text = "0";
            this.J1_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // J2_score
            // 
            this.J2_score.BackColor = System.Drawing.Color.Aquamarine;
            this.J2_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.J2_score.Location = new System.Drawing.Point(584, 307);
            this.J2_score.Name = "J2_score";
            this.J2_score.Size = new System.Drawing.Size(79, 48);
            this.J2_score.TabIndex = 9;
            this.J2_score.Text = "0";
            this.J2_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Partie
            // 
            this.Partie.BackColor = System.Drawing.Color.Chartreuse;
            this.Partie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Partie.Location = new System.Drawing.Point(497, 430);
            this.Partie.Name = "Partie";
            this.Partie.Size = new System.Drawing.Size(66, 31);
            this.Partie.TabIndex = 10;
            this.Partie.Text = "Partie";
            this.Partie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Num_partie
            // 
            this.Num_partie.BackColor = System.Drawing.Color.DarkOrange;
            this.Num_partie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_partie.Location = new System.Drawing.Point(578, 430);
            this.Num_partie.Name = "Num_partie";
            this.Num_partie.Size = new System.Drawing.Size(28, 31);
            this.Num_partie.TabIndex = 11;
            this.Num_partie.Text = "1";
            this.Num_partie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(499, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 63);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(584, 241);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 63);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem,
            this.quitToolStripMenuItem1});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.newGameToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "New Game";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem1
            // 
            this.quitToolStripMenuItem1.Name = "quitToolStripMenuItem1";
            this.quitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem1.Text = "Quit*";
            this.quitToolStripMenuItem1.Click += new System.EventHandler(this.quitToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(117, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Click Left To Play";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LawnGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(612, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "/";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkOrange;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(646, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button_WOC3
            // 
            this.button_WOC3.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC3.BorderColor = System.Drawing.Color.Gold;
            this.button_WOC3.ButtonColor = System.Drawing.Color.Red;
            this.button_WOC3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_WOC3.FlatAppearance.BorderSize = 0;
            this.button_WOC3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC3.ForeColor = System.Drawing.Color.Gold;
            this.button_WOC3.Location = new System.Drawing.Point(663, 33);
            this.button_WOC3.Name = "button_WOC3";
            this.button_WOC3.OnHoverBorderColor = System.Drawing.Color.Red;
            this.button_WOC3.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.button_WOC3.OnHoverTextColor = System.Drawing.Color.Red;
            this.button_WOC3.Size = new System.Drawing.Size(59, 28);
            this.button_WOC3.TabIndex = 22;
            this.button_WOC3.Text = "Stop";
            this.button_WOC3.TextColor = System.Drawing.Color.White;
            this.button_WOC3.UseVisualStyleBackColor = false;
            this.button_WOC3.Click += new System.EventHandler(this.button_WOC3_Click);
            // 
            // button_WOC4
            // 
            this.button_WOC4.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC4.BorderColor = System.Drawing.Color.Gold;
            this.button_WOC4.ButtonColor = System.Drawing.Color.Red;
            this.button_WOC4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_WOC4.FlatAppearance.BorderSize = 0;
            this.button_WOC4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC4.ForeColor = System.Drawing.Color.Gold;
            this.button_WOC4.Location = new System.Drawing.Point(728, 33);
            this.button_WOC4.Name = "button_WOC4";
            this.button_WOC4.OnHoverBorderColor = System.Drawing.Color.Red;
            this.button_WOC4.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.button_WOC4.OnHoverTextColor = System.Drawing.Color.Red;
            this.button_WOC4.Size = new System.Drawing.Size(59, 28);
            this.button_WOC4.TabIndex = 23;
            this.button_WOC4.Text = "Play";
            this.button_WOC4.TextColor = System.Drawing.Color.White;
            this.button_WOC4.UseVisualStyleBackColor = false;
            this.button_WOC4.Click += new System.EventHandler(this.button_WOC4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gold;
            this.label10.Location = new System.Drawing.Point(584, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 21);
            this.label10.TabIndex = 24;
            this.label10.Text = "Music";
            // 
            // UneForme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(799, 577);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button_WOC4);
            this.Controls.Add(this.button_WOC3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Num_partie);
            this.Controls.Add(this.Partie);
            this.Controls.Add(this.J2_score);
            this.Controls.Add(this.J1_score);
            this.Controls.Add(this.Tour);
            this.Controls.Add(this.J2_nom);
            this.Controls.Add(this.Joueur_Tour);
            this.Controls.Add(this.J1_nom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UneForme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Window Tic Tac Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.EnabledChanged += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Tour;
        private System.Windows.Forms.Label Joueur_Tour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label J1_nom;
        private System.Windows.Forms.Label J2_nom;
        private System.Windows.Forms.Label J1_score;
        private System.Windows.Forms.Label J2_score;
        private System.Windows.Forms.Label Partie;
        private System.Windows.Forms.Label Num_partie;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ePOSOne.btnProduct.Button_WOC button_WOC3;
        private ePOSOne.btnProduct.Button_WOC button_WOC4;
        private System.Windows.Forms.Label label10;
    }
}

