namespace Race_of_Death
{
    partial class esc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(esc));
            this.Resume = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Resume
            // 
            this.Resume.BackColor = System.Drawing.Color.Silver;
            this.Resume.Location = new System.Drawing.Point(54, 42);
            this.Resume.Name = "Resume";
            this.Resume.Size = new System.Drawing.Size(75, 85);
            this.Resume.TabIndex = 0;
            this.Resume.Text = "Resume";
            this.Resume.UseVisualStyleBackColor = false;
            this.Resume.Click += new System.EventHandler(this.Resume_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Silver;
            this.Exit.Location = new System.Drawing.Point(54, 146);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 85);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // esc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(179, 290);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Resume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "esc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "esc";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Resume;
        private System.Windows.Forms.Button Exit;
    }
}