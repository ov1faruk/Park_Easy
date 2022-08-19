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
    public partial class vehicleType : Form
    {
        public vehicleType()
        {
            InitializeComponent();
            goback.Parent = pictureBox1;
            goback.BackColor = Color.Transparent;
        }

        private void goback_Click(object sender, EventArgs e)
        {
            adminPanel ad = new adminPanel();
            ad.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
