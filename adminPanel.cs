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
    public partial class adminPanel : Form
    {
        public adminPanel()
        {
            InitializeComponent();
            logout.Parent = pictureBox2;
            logout.BackColor = Color.Transparent;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DiverType_Click(object sender, EventArgs e)
        {

        }

        private void driverType_Click(object sender, EventArgs e)
        {
            driverType dtype = new driverType();
            dtype.Show();
            this.Hide();
        }

        private void driverType_MouseHover(object sender, EventArgs e)
        {
            driverType.BackColor = Color.Magenta;
        }

        private void driverType_MouseLeave(object sender, EventArgs e)
        {
            driverType.BackColor = Color.DimGray;
        }

        private void vehicleType_MouseHover(object sender, EventArgs e)
        {
            vehicleType.BackColor = Color.Magenta;
        }

        private void vehicleType_MouseLeave(object sender, EventArgs e)
        {
            vehicleType.BackColor = Color.DimGray;
        }

        private void registration_MouseHover(object sender, EventArgs e)
        {
            registration.BackColor = Color.Magenta;
        }

        private void registration_MouseLeave(object sender, EventArgs e)
        {
            registration.BackColor = Color.DimGray;
        }

        private void allVehicle_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void allVehicle_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void checkin_MouseHover(object sender, EventArgs e)
        {
            checkin.BackColor = Color.Magenta;
        }

        private void checkin_MouseLeave(object sender, EventArgs e)
        {
            checkin.BackColor = Color.DimGray;
        }

        private void checkout_Click(object sender, EventArgs e)
        {
            checkOUT co = new checkOUT();
            co.Show();
            this.Hide();
        }

        private void checkout_MouseHover(object sender, EventArgs e)
        {
            checkout.BackColor = Color.Magenta;
        }

        private void checkout_MouseLeave(object sender, EventArgs e)
        {
            checkout.BackColor = Color.DimGray;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            driverType.BackColor = Color.Magenta;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            driverType.BackColor = Color.DimGray;
        }

        private void parkhistory_MouseHover(object sender, EventArgs e)
        {
            parkhistory.BackColor = Color.Magenta;
        }

        private void parkhistory_MouseLeave(object sender, EventArgs e)
        {
            parkhistory.BackColor = Color.DimGray;
        }

        private void vehicleType_Click(object sender, EventArgs e)
        {
            vehicleType vtype = new vehicleType();
            vtype.Show();
            this.Hide();
        }

        private void registration_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Hide();
        }

        private void checkin_Click(object sender, EventArgs e)
        {
            checkIN ci = new checkIN();
            ci.Show();
            this.Hide();
        }

        private void parkhistory_Click(object sender, EventArgs e)
        {
            parkHistory ph = new parkHistory();
            ph.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click_1(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
