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
using System.Configuration;

namespace CMPT291_Project
{
    public partial class CustEntry : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public CustEntry()
        {
            InitializeComponent();
            
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command stream to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }

        private void custentrycancel_Click(object sender, EventArgs e)
        {
            this.CustEntryPanel.Controls.Clear();
            CustomersFrm CustomersFrm_Vrb = new CustomersFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            CustomersFrm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.CustEntryPanel.Controls.Add(CustomersFrm_Vrb);
            CustomersFrm_Vrb.Show();
        }

        private void custentryacc_Click(object sender, EventArgs e)
        {
            try
            {
                myCommand.CommandText = "insert into Customer values ('" + fnameentry.Text +
                    "','" + mnameentry.Text + "','" + lnameentry.Text + "','" + add1entry.Text + 
                    "','" + add2entry.Text + "','" + cityentry.Text + "','" + proventry.Text + "','" +
                    postalentry.Text + "','" + dobentry.Text + "'," + phoneentry.Text + ",'" + cinsentry.Text
                    + "','" + dlentry.Text + "'," + mementry.Text + ")";
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }

            this.CustEntryPanel.Controls.Clear();
            CustomersFrm CustomersFrm_Vrb = new CustomersFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            CustomersFrm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.CustEntryPanel.Controls.Add(CustomersFrm_Vrb);
            CustomersFrm_Vrb.Show();
        }
    }
}
