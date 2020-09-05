namespace Race_of_Death
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.exit_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newgame_button = new System.Windows.Forms.Button();
            this.howtoplay_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Location = new System.Drawing.Point(138, 418);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(179, 64);
            this.exit_button.TabIndex = 2;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            this.exit_button.MouseEnter += new System.EventHandler(this.OnMouseEnterButton1);
            this.exit_button.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.newgame_button);
            this.groupBox1.Controls.Add(this.howtoplay_button);
            this.groupBox1.Controls.Add(this.exit_button);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 497);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // newgame_button
            // 
            this.newgame_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newgame_button.Location = new System.Drawing.Point(138, 278);
            this.newgame_button.Name = "newgame_button";
            this.newgame_button.Size = new System.Drawing.Size(179, 64);
            this.newgame_button.TabIndex = 0;
            this.newgame_button.Text = "New Game";
            this.newgame_button.UseVisualStyleBackColor = true;
            this.newgame_button.Click += new System.EventHandler(this.newgame_button_Click);
            this.newgame_button.MouseEnter += new System.EventHandler(this.OnMouseEnterButton3);
            this.newgame_button.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton3);
            // 
            // howtoplay_button
            // 
            this.howtoplay_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howtoplay_button.Location = new System.Drawing.Point(138, 348);
            this.howtoplay_button.Name = "howtoplay_button";
            this.howtoplay_button.Size = new System.Drawing.Size(179, 64);
            this.howtoplay_button.TabIndex = 1;
            this.howtoplay_button.Text = "How To Play";
            this.howtoplay_button.UseVisualStyleBackColor = true;
            this.howtoplay_button.Click += new System.EventHandler(this.howtoplay_button_Click);
            this.howtoplay_button.MouseEnter += new System.EventHandler(this.OnMouseEnterButton2);
            this.howtoplay_button.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton2);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 497);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(472, 521);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Race of Death";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button newgame_button;
        private System.Windows.Forms.Button howtoplay_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}