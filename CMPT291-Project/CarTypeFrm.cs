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
    public partial class CarTypeFrm : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public int state = 0;

        public string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;


        public CarTypeFrm()
        {
            InitializeComponent();
            myCommand = new SqlCommand("select * from CarType");
            state = 2;
            execute(); //fills datatable upon loading screen
            state = 0;

        }

        private void execute()
        {
            myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            myCommand.Connection = myConnection;
            if (state == 1)
            {
                try
                {
                    myCommand.ExecuteNonQuery();
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }
            }
            else if (state == 2)
            {
                fillTable();
            }
            myConnection.Close();

        }

        private void QueryFrm_Load(object sender, EventArgs e)
        {


        }

        private void fillTable()
        {
            myCommand.CommandType = CommandType.Text;
            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            DataTable dt = new DataTable();
            myAdapter.Fill(dt);


            //change column names
            dt.Columns["CarTypeId"].ColumnName = "ID";
            dt.Columns["DailyRate"].ColumnName = "Daily Rate";
            dt.Columns["WeeklyRate"].ColumnName = "Weekly Rate";
            dt.Columns["MonthlyRate"].ColumnName = "Monthly Rate";

            CarTypeData.DataSource = dt;

            //formats cells
            CarTypeData.Columns["Daily Rate"].DefaultCellStyle.Format = "N2";
            CarTypeData.Columns["Weekly Rate"].DefaultCellStyle.Format = "N2";
            CarTypeData.Columns["Monthly Rate"].DefaultCellStyle.Format = "N2";

        }

        private void CarTypeAdd_Click_1(object sender, EventArgs e)
        {
            CarTypeEntry CarTypeEntry_Vrb = new CarTypeEntry() { TopLevel = true, TopMost = true };
            CarTypeEntry_Vrb.FormBorderStyle = FormBorderStyle.None;
            CarTypeEntry_Vrb.ShowDialog();
            myCommand.CommandText = CarTypeEntry_Vrb.newCommand;
            state = CarTypeEntry_Vrb.state;
            execute();

        }
    }
}


