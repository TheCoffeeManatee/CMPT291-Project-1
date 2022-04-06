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
    public partial class BranchEntry : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public BranchEntry()
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



        private void branchcancel_Click(object sender, EventArgs e)
        {
            this.BranchEPanel.Controls.Clear();
            BranchFrm BranchFrm_Vrb = new BranchFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            BranchFrm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.BranchEPanel.Controls.Add(BranchFrm_Vrb);
            BranchFrm_Vrb.Show();
        }

        private void carentrryaccept_Click(object sender, EventArgs e)
        {
            try
            {
                myCommand.CommandText = "insert into Branch values ('" + descentry.Text +
                    "','" + addL1entry.Text + "','" + addL2Entry.Text + "','" + cityentry.Text + "','"
                    + proventry.Text + "','" + postalentry.Text + "'," + phoneentry.Text + ")";
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }

            this.BranchEPanel.Controls.Clear();
            BranchFrm BranchFrm_Vrb = new BranchFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            BranchFrm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.BranchEPanel.Controls.Add(BranchFrm_Vrb);
            BranchFrm_Vrb.Show();
        }
    }
}
