using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Park_Easy
{
    public partial class Registration : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-USM56V1\\SQLEXPRESS;Initial Catalog=parkeasyDB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public Registration()
        {
            InitializeComponent();
            goback.Parent = pictureBox1;
            goback.BackColor = Color.Transparent;
           
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void goback_Click(object sender, EventArgs e)
        {
            adminPanel ad = new adminPanel();
            ad.Show();
            this.Hide();
        }

        private void save_Click(object sender, EventArgs e)
        {

        }
    }
}
