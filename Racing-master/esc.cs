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
    public partial class esc : Form
    {
        public esc()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Resume_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
