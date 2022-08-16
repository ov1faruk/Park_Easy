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
            try
            {
                if (userid.Text != null & password.Text != null)
                {
                    var item = db.loginusers.Where(s => s.User_ID == userid.Text & s.Password == password.Text).FirstOrDefault();
                    if (item != null)
                    {
                        Welcome wc = new Welcome();
                        wc.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("UserID or Password Not Found! Consider Creating an Account First :) ");
                    }
                }
                else
                {
                    MessageBox.Show("UserID or Password Not Valid!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void regLabel_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
