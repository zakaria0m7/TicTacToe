namespace Our_Tic_Tac
{
    partial class Winner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Winner));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_WOC4 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(146, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Jokerman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // button_WOC4
            // 
            this.button_WOC4.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC4.BorderColor = System.Drawing.Color.DeepPink;
            this.button_WOC4.ButtonColor = System.Drawing.Color.Blue;
            this.button_WOC4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_WOC4.FlatAppearance.BorderSize = 0;
            this.button_WOC4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC4.ForeColor = System.Drawing.Color.Gold;
            this.button_WOC4.Location = new System.Drawing.Point(96, 321);
            this.button_WOC4.Name = "button_WOC4";
            this.button_WOC4.OnHoverBorderColor = System.Drawing.Color.Red;
            this.button_WOC4.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.button_WOC4.OnHoverTextColor = System.Drawing.Color.Red;
            this.button_WOC4.Size = new System.Drawing.Size(104, 28);
            this.button_WOC4.TabIndex = 24;
            this.button_WOC4.Text = "New Game";
            this.button_WOC4.TextColor = System.Drawing.Color.White;
            this.button_WOC4.UseVisualStyleBackColor = false;
            this.button_WOC4.Click += new System.EventHandler(this.button_WOC4_Click);
            // 
            // button_WOC1
            // 
            this.button_WOC1.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC1.BorderColor = System.Drawing.Color.Gold;
            this.button_WOC1.ButtonColor = System.Drawing.Color.Red;
            this.button_WOC1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.ForeColor = System.Drawing.Color.Gold;
            this.button_WOC1.Location = new System.Drawing.Point(258, 321);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Red;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Red;
            this.button_WOC1.Size = new System.Drawing.Size(104, 28);
            this.button_WOC1.TabIndex = 25;
            this.button_WOC1.Text = "Play again";
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseVisualStyleBackColor = false;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // Winner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.button_WOC4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Winner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Winner";
            this.Load += new System.EventHandler(this.Winner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC button_WOC4;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
    }
}