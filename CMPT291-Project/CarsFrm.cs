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
    public partial class CarsFrm : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public CarsFrm()
        {
            InitializeComponent();
            fillTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.CarsPanel.Controls.Clear();
            CarEntry CarEntry_Vrb = new CarEntry() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            CarEntry_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.CarsPanel.Controls.Add(CarEntry_Vrb);
            CarEntry_Vrb.Show();
        }

        private void fillTable()
        {
            myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            myCommand = new SqlCommand("select * from Car");
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            DataTable dt = new DataTable();
            myAdapter.Fill(dt);

            //change column names
            dt.Columns["CarTypeId"].ColumnName = "Type ID";
            dt.Columns["BranchId"].ColumnName = "Branch ID";

            carData.DataSource = dt;
            myConnection.Close();
        }
    }
}
