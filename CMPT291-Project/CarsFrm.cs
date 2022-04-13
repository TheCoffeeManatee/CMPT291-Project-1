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
        public int state = 0;


        public string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public CarsFrm()
        {
            InitializeComponent();
            myCommand = new SqlCommand("select * from Car");
            state = 2;
            execute();
            state = 0;
        }

        private void execute()
        {
            myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            myCommand.Connection = myConnection;
            if(state == 1)
            {
                try
                {
                    myCommand.ExecuteNonQuery();
                }   
                catch(Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }
            }
            else if(state == 2)
            {
                fillTable();
            }
            myConnection.Close();

        }

        private void fillTable()
        {
            myCommand.CommandType = CommandType.Text;
            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            DataTable dt = new DataTable();
            myAdapter.Fill(dt);

            //change column names
            dt.Columns["CarTypeId"].ColumnName = "Type ID";
            dt.Columns["BranchId"].ColumnName = "Branch ID";

            carData.DataSource = dt;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            CarEntry CarEntry_Vrb = new CarEntry() { TopLevel = true, TopMost = true };
            CarEntry_Vrb.FormBorderStyle = FormBorderStyle.None;
            CarEntry_Vrb.ShowDialog();
            myCommand.CommandText = CarEntry_Vrb.newCommand;
            state = CarEntry_Vrb.state;
            execute();
            
        }
    }
}
