using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Park_Easy
{
    public partial class Login : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Login()
        {
            
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loginLabel.Parent = pictureBox1;
            loginLabel.BackColor = Color.Transparent;
            regLabel.Parent = pictureBox1;
            regLabel.BackColor = Color.Transparent;
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
           
                       adminPanel ap = new adminPanel();
                       ap.Show();
                       this.Hide();
                   
        }

        private void regLabel_Click(object sender, EventArgs e)
        {
            regUser reguser = new regUser();
            reguser.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
