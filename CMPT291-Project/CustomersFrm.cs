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
    public partial class CustomersFrm : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;


        public CustomersFrm()
        {
            InitializeComponent();
            fillTable();
        }

        private void fillTable()
        {
            myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            myCommand = new SqlCommand("select * from Customer");
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            DataTable dt = new DataTable();
            myAdapter.Fill(dt);
            CustData.DataSource = dt;
            myConnection.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.CustomerPanel.Controls.Clear();
            CustEntry CustEntry_Vrb = new CustEntry() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            CustEntry_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.CustomerPanel.Controls.Add(CustEntry_Vrb);
            CustEntry_Vrb.Show();
        }
    }
}
