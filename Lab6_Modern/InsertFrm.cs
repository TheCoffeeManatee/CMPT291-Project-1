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
    
    public partial class InsertFrm : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public InsertFrm()
        {
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HomeFormPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                myCommand.CommandText = "insert into student values (" + ID.Text +
                    ",'" + Name.Text + "'," + Grade.Text + ")";
                MessageBox.Show(myCommand.CommandText);

                myCommand.ExecuteNonQuery();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }
    }
}
