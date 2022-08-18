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
    public partial class driverType : Form
    {
        public driverType()
        {
            InitializeComponent();
        }
        private void fillGrid(string search)
        {
            string query = string.Empty;
            if (string.IsNullOrEmpty(search))
            {
                query = "select driverID [ID] , driverType [Driver Type], [description] from driverTypeTable";
            }
            else
            {
                query = "select driverID [ID] , driverType [Driver Type], [description] from driverTypeTable "+
                        " where(driverType + '' + description) Like '%"+search.Trim()+"%'; ";
            }

            DataTable dt = accessDatabase.Select(query);
            if (dt != null)
            {
                if (dt.Rows.Count>0)
                        {
                            resultsdriverdetails.DataSource = dt;
                            resultsdriverdetails.Columns[0].Width = 100;
                            resultsdriverdetails.Columns[1].Width = 200;
                            resultsdriverdetails.Columns[2].Width = 300;


                }
            }
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
            cancel.Enabled = true;
            update.Enabled = true;
        }

        private void disableControl()
        {
            save.Enabled = true;
            searchdriverdetails.Enabled = true;
            resultsdriverdetails.Enabled = true;
            cancel.Enabled = false;
            update.Enabled = false;
            clearForm();
            fillGrid(string.Empty);
        }

        private void driverType_Load(object sender, EventArgs e)
        {
            fillGrid(string.Empty);
        }

        private void searchdriverdetails_TextChanged(object sender, EventArgs e)
        {
            fillGrid(searchdriverdetails.Text.Trim());
        }

        private void clear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            disableControl();
        }

        private void save_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (drivertypedetails.Text.Trim().Length==0)
            {
                ep.SetError(drivertypedetails, "Required!");
                drivertypedetails.Focus();
                return;
            }

            //DataTable dt = accessDatabase.Select("select * from driverTypeTable where  ")
        }
    }
}
