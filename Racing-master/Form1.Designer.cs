namespace Race_of_Death
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelleft = new System.Windows.Forms.Panel();
            this.panelmid = new System.Windows.Forms.Panel();
            this.panelright = new System.Windows.Forms.Panel();
            this.Start = new System.Windows.Forms.Timer(this.components);
            this.carsTimer = new System.Windows.Forms.Timer(this.components);
            this.coinTimer = new System.Windows.Forms.Timer(this.components);
            this.metiLabel = new System.Windows.Forms.Label();
            this.scorelb = new System.Windows.Forms.Label();
            this.updateLevellb = new System.Windows.Forms.Label();
            this.scorelabel = new System.Windows.Forms.Label();
            this.highScorelb = new System.Windows.Forms.Label();
            this.pitTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panelleft
            // 
            resources.ApplyResources(this.panelleft, "panelleft");
            this.panelleft.Name = "panelleft";
            // 
            // panelmid
            // 
            resources.ApplyResources(this.panelmid, "panelmid");
            this.panelmid.Name = "panelmid";
            // 
            // panelright
            // 
            resources.ApplyResources(this.panelright, "panelright");
            this.panelright.Name = "panelright";
            this.panelright.Paint += new System.Windows.Forms.PaintEventHandler(this.panelright_Paint);
            // 
            // Start
            // 
            this.Start.Interval = 40;
            this.Start.Tick += new System.EventHandler(this.Start_Tick);
            // 
            // carsTimer
            // 
            this.carsTimer.Tick += new System.EventHandler(this.carsTimer_Tick);
            // 
            // coinTimer
            // 
            this.coinTimer.Interval = 500;
            this.coinTimer.Tick += new System.EventHandler(this.coinTimer_Tick);
            // 
            // metiLabel
            // 
            resources.ApplyResources(this.metiLabel, "metiLabel");
            this.metiLabel.BackColor = System.Drawing.Color.Red;
            this.metiLabel.Name = "metiLabel";
            // 
            // scorelb
            // 
            resources.ApplyResources(this.scorelb, "scorelb");
            this.scorelb.BackColor = System.Drawing.Color.Transparent;
            this.scorelb.ForeColor = System.Drawing.Color.Red;
            this.scorelb.Name = "scorelb";
            // 
            // updateLevellb
            // 
            resources.ApplyResources(this.updateLevellb, "updateLevellb");
            this.updateLevellb.BackColor = System.Drawing.Color.Transparent;
            this.updateLevellb.ForeColor = System.Drawing.Color.White;
            this.updateLevellb.Name = "updateLevellb";
            // 
            // scorelabel
            // 
            resources.ApplyResources(this.scorelabel, "scorelabel");
            this.scorelabel.BackColor = System.Drawing.Color.Transparent;
            this.scorelabel.ForeColor = System.Drawing.Color.White;
            this.scorelabel.Name = "scorelabel";
            // 
            // highScorelb
            // 
            resources.ApplyResources(this.highScorelb, "highScorelb");
            this.highScorelb.BackColor = System.Drawing.Color.Turquoise;
            this.highScorelb.Name = "highScorelb";
            // 
            // pitTimer
            // 
            this.pitTimer.Interval = 40;
            this.pitTimer.Tick += new System.EventHandler(this.pitTimer_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.highScorelb);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.updateLevellb);
            this.Controls.Add(this.scorelb);
            this.Controls.Add(this.metiLabel);
            this.Controls.Add(this.panelright);
            this.Controls.Add(this.panelmid);
            this.Controls.Add(this.panelleft);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Panel panelmid;
        private System.Windows.Forms.Panel panelright;
        private System.Windows.Forms.Timer Start;
        private System.Windows.Forms.Timer carsTimer;
        private System.Windows.Forms.Timer coinTimer;
        private System.Windows.Forms.Label metiLabel;
        private System.Windows.Forms.Label scorelb;
        private System.Windows.Forms.Label updateLevellb;
        private System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.Label highScorelb;
        private System.Windows.Forms.Timer pitTimer;
    }
}

