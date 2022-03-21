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
    
    public partial class BranchFrm : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public BranchFrm()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HomeFormPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomersLbl_Click(object sender, EventArgs e)
        {
            
        }

        private void BranchAdd_Click(object sender, EventArgs e)
        {
            this.BranchPanel.Controls.Clear();
            BranchEntry BranchEntry_Vrb = new BranchEntry() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            BranchEntry_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.BranchPanel.Controls.Add(BranchEntry_Vrb);
            BranchEntry_Vrb.Show();
        }
    }
}
