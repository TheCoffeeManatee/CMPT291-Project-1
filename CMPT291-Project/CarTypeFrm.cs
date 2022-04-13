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
        // state corresponds to the car type entry form state variable, and determines the actions taken on management form closure
        public int state = 0;

        public string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;


        public CarTypeFrm()
        {
            InitializeComponent();
            myCommand = new SqlCommand("select * from CarType");
            // this sequence changes state to allow the table to be populated with the entire table, then resets it
            state = 2;
            execute(); //fills datatable upon loading screen
            state = 0;

        }

        private void execute()
        {
            myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            myCommand.Connection = myConnection;
            // this block determines, based on state, whether the tables should be edited, data grid populated, or no action taken
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
        
        // this entire function just gets the table data from the server and formats the columns appropriately
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
        
        // this uses a dialog box to get the data from the user, and sets the sql command to the generated command from the management form
        // and matches the state to the management forms state, then executes the appropriate command
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


