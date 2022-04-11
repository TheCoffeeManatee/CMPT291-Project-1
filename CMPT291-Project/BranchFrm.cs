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

        public string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;


        public BranchFrm()
        {
            InitializeComponent();
            fillTable(); //fills datatable upon loading screen
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

        private void fillTable()
        {
            myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            myCommand = new SqlCommand("select * from Branch");
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            DataTable dt = new DataTable();
            myAdapter.Fill(dt);

            //change heading names
            dt.Columns["BranchId"].ColumnName = "Branch ID";
            dt.Columns["StreetAddress1"].ColumnName = "Address Line 1";
            dt.Columns["StreetAddress2"].ColumnName = "Address Line 2";
            dt.Columns["PostalCode"].ColumnName = "Postal Code";

            BranchTable.DataSource = dt;
            myConnection.Close();
        }

        private void BranchTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
