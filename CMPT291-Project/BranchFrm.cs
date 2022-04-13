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
        // state corresponds to the entry form public variable state which is used to determine the operation performed
        // upon closing the management form
        public int state = 0;

        public string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;


        public BranchFrm()
        {
            InitializeComponent();
            myCommand = new SqlCommand("select * from Branch");
            // the state is set to fill the tables, the tables are filled, and the state is changed back to perform no operations
            state = 2;
            execute(); //fills datatable upon loading screen
            state = 0;
        }

        private void execute()
        {
            myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            myCommand.Connection = myConnection;
            // this block either edits the tables if the state is 1, or populates the display if it is 2, no action is taken if it is 0
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
        
        // this is used to populate the display
        private void fillTable()
        {
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
        }

        private void BranchManage_Click(object sender, EventArgs e)
        {
            // the parameters here allow for the use of a management dialog box for easier screen data transfer
            BranchEntry BranchEntry_Vrb = new BranchEntry() { TopLevel = true, TopMost = true };
            BranchEntry_Vrb.FormBorderStyle = FormBorderStyle.None;
            BranchEntry_Vrb.ShowDialog();
            // once the management form is closed, this forms sqlcommand is set to the generated command from the dialog box form, and the state is set to match as well
            myCommand.CommandText = BranchEntry_Vrb.newCommand;
            state = BranchEntry_Vrb.state;
            // the new command is executed based on newly assigned management state
            execute();
        }
    }
}
