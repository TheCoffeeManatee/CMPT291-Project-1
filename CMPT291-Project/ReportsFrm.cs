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
    public partial class ReportsFrm : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public ReportsFrm()
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

        private void ReportUpdate1_Click(object sender, EventArgs e)
        {
            string d1 = DatePick1.Value.ToString("yyyy/MM/dd");
            string d2 = DatePick2.Value.ToString("yyyy/MM/dd");
            Date1.Text = d1;
            Date1.Visible = true;
            Date2.Text = d2;
            Date2.Visible = true;

        }

        private void UpdateReport2_Click(object sender, EventArgs e)
        {
            string d3 = DatePick3.Value.ToString("yyyy/MM/dd");
            string d4 = DatePick4.Value.ToString("yyyy/MM/dd");
            Date3.Text = d3;
            Date3.Visible = true;
            Date4.Text = d4;
            Date4.Visible = true;
        }
    }
}
