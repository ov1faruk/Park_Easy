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
    public partial class driverType : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-USM56V1\\SQLEXPRESS;Initial Catalog=parkeasyDB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        int drivertype;
        public driverType()
        {
            InitializeComponent();
            displayData();
            goback.Parent = pictureBox1;
            goback.BackColor = Color.Transparent;
        }
        private void fillGrid(string search)
        {
            con.Open();
            da = new SqlDataAdapter("select * from driverTypeTable", con);
            dt = new DataTable();
            da.Fill(dt);
            resultsdriverdetails.DataSource = dt;
            con.Close();

        }

        private void clearForm()
        {
            drivertypedetails.Text = "";
            desciptionDriverdetails.Text = "";
            searchdriverdetails.Text = "";

        }

        private void enableControl()
        {
            save.Enabled = false;
            searchdriverdetails.Enabled = false;
            resultsdriverdetails.Enabled = false;
            delete.Enabled = true;
            update.Enabled = true;
        }

        private void disableControl()
        {
            save.Enabled = true;
            searchdriverdetails.Enabled = true;
            resultsdriverdetails.Enabled = true;
            delete.Enabled = false;
            update.Enabled = false;
            clearForm();
            fillGrid(string.Empty);
        }

        private void driverType_Load(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter ("SELECT * FROM driverTypeTable" ,con);
           
            DataTable dt = new DataTable();
            da.Fill(dt);
            resultsdriverdetails.DataSource = dt;
            
            con.Close();

        }

        private void searchdriverdetails_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter ("SELECT * FROM driverTypeTable WHERE driverType LIKE '%" +searchdriverdetails.Text+ "%'",con);
            
            DataTable dt= new DataTable();
            da.Fill(dt);
            resultsdriverdetails.DataSource = dt;
            
            con.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("delete from driverTypeTable where driverID='" + drivertype + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("DELETED!");

            con.Close();
            displayData();
           

        }


        private void save_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into driverTypeTable values('" + drivertypedetails.Text + "','" + desciptionDriverdetails.Text + "') ", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved!");
            con.Close();
            drivertypedetails.Text = "";
            desciptionDriverdetails.Text = "";
            searchdriverdetails.Text = "";

            displayData();
            con.Close();
            
        }

        private void displayData()
        {
            


            con.Open();
            da = new SqlDataAdapter("select * from driverTypeTable", con);
            dt = new DataTable();
            da.Fill(dt);
            resultsdriverdetails.DataSource = dt;
            con.Close();

        }


        private void label1_Click(object sender, EventArgs e)
        {
            adminPanel ad = new adminPanel();
            ad.Show();
            this.Hide();
        }

        private void resultsdriverdetails_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            drivertype = Convert.ToInt32(resultsdriverdetails.Rows[e.RowIndex].Cells[0].Value.ToString());
            drivertypedetails.Text = resultsdriverdetails.Rows[e.RowIndex].Cells[1].Value.ToString();
            desciptionDriverdetails.Text = resultsdriverdetails.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void update_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("update driverTypeTable set driverType ='" + drivertypedetails.Text + "',description='" + desciptionDriverdetails.Text + "'where driverID='"+drivertype+"'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("UPDATED!");
            con.Close();
            clearForm();
            displayData();
            
        }

       


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
