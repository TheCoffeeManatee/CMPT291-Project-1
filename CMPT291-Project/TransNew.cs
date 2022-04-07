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
    public partial class TransNew : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public TransNew()
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

        private void AddCustBtn_Click(object sender, EventArgs e)
        {
            CustName.Visible = true;
            CustAdd1.Visible = true;
            CustAdd2.Visible = true;
            CustCity.Visible = true;
            Province.Visible = true;
            CustPhone.Visible = true;
            MemStatus.Visible = true;

        }

        private void FindCars_Click(object sender, EventArgs e)
        {
            PriceLbl.Visible = true;
        }
    }
}
