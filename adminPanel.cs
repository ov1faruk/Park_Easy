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
            allVehicle.BackColor = Color.Magenta;
        }

        private void allVehicle_MouseLeave(object sender, EventArgs e)
        {
            allVehicle.BackColor = Color.DimGray;
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
    }
}
