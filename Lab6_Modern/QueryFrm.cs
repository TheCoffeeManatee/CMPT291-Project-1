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

namespace Lab6_Modern
{
    public partial class QueryFrm : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public QueryFrm()
        {
            InitializeComponent();
            ///////////////////////////////
            operation.Items.Clear();
            operation.Items.Add("Show all");
            operation.Items.Add("Show with starting grade: ");
            //////////////////////////////////

            String connectionString = "Server = DESKTOP-L3H29R4; Database = ConnectTutorial; Trusted_Connection = yes;";

            SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds

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

        private void QueryFrm_Load(object sender, EventArgs e)
        {

        }

        private void QueryBtn_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from student";
            if (operation.Text == "Show with starting grade: ")
                myCommand.CommandText += " where grade >= " + SGrade.Text;

            try
            {
                MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                student.Rows.Clear();
                while (myReader.Read())
                {
                    student.Rows.Add(myReader["id"].ToString(), myReader["name"].ToString(), myReader["grade"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }
    }
}
