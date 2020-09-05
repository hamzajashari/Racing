using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race_of_Death
{
    public partial class Start : Form
    {
        Sound sound = new Sound();
        public Start()
        {
            InitializeComponent();
            sound.playIntro();
            callmouseenter();


        }
        void callmouseenter()
        {
            exit_button.MouseEnter += OnMouseEnterButton1;
            exit_button.MouseLeave += OnMouseLeaveButton1;

            howtoplay_button.MouseEnter += OnMouseEnterButton2;
            howtoplay_button.MouseLeave += OnMouseLeaveButton2;

            newgame_button.MouseEnter += OnMouseEnterButton3;
            newgame_button.MouseLeave += OnMouseLeaveButton3;
        }
        private void OnMouseEnterButton1(object sender, EventArgs e)
        {
           exit_button.BackColor = Color.PaleVioletRed; // or Color.Red or whatever you want
           exit_button.FlatAppearance.BorderSize = 1;
           exit_button.FlatAppearance.BorderColor = Color.Black;
        }
        private void OnMouseLeaveButton1(object sender, EventArgs e)
        {
            exit_button.BackColor = SystemColors.ButtonFace;
        }
        private void OnMouseEnterButton2(object sender, EventArgs e)
        {
            howtoplay_button.BackColor = Color.AliceBlue; // or Color.Red or whatever you want
        }
        private void OnMouseLeaveButton2(object sender, EventArgs e)
        {
            howtoplay_button.BackColor = SystemColors.ButtonFace;
        }
        private void OnMouseEnterButton3(object sender, EventArgs e)
        {
            newgame_button.BackColor = Color.AliceBlue; // or Color.Red or whatever you want
        }
        private void OnMouseLeaveButton3(object sender, EventArgs e)
        {
            newgame_button.BackColor = Color.Empty;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void newgame_button_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            if ( form.ShowDialog() == DialogResult.OK)
            {   
               Application.Run(new Start());
            }
        }

        private void howtoplay_button_Click(object sender, EventArgs e)
        {
            HowToPlay howToPlay = new HowToPlay();
            //this.Hide();
            if (howToPlay.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
           //this.Show();
        }
    }
}
