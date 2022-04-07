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
    public partial class CarEntry : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
       
        public CarEntry()
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


        private void carentrycancel_Click_1(object sender, EventArgs e)
        {
            this.CarEntryPanel.Controls.Clear();
            CarsFrm CarsFrm_Vrb = new CarsFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            CarsFrm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.CarEntryPanel.Controls.Add(CarsFrm_Vrb);
            CarsFrm_Vrb.Show();
        }

        private void carentrryaccept_Click(object sender, EventArgs e)
        {
            try
            {
                myCommand.CommandText = "insert into Car values ('" + vinentry.Text +
                    "','" + makeentry.Text + "','" + modelentry.Text + "'," + yearentry.Text + ","
                    + seatsentry.Text + ",'" + colourentry.Text + "','" + insentry.Text + "'," + mileentry.Text + ","
                    + branchentry.Text + "," + typeentry.Text + ")";
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }

            this.CarEntryPanel.Controls.Clear();
            CarsFrm CarsFrm_Vrb = new CarsFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            CarsFrm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.CarEntryPanel.Controls.Add(CarsFrm_Vrb);
            CarsFrm_Vrb.Show();
        }

        private void modelL_Click(object sender, EventArgs e)
        {

        }
    }
}
