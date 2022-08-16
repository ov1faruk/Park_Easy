using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Park_Easy
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            regLabel1.Parent = pictureBox1;
            regLabel1.BackColor = Color.Transparent;
            regClear.Parent = pictureBox1;
            regClear.BackColor = Color.Transparent;
            backToLogin.Parent = pictureBox1;
            backToLogin.BackColor = Color.Transparent;
        }

        private void regLabel1_Click(object sender, EventArgs e)
        {

        }

        private void regClear_Click(object sender, EventArgs e)
        {

        }

        private void backToLogin_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void regName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
