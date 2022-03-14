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
    public partial class CarTypeEntry : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public CarTypeEntry()
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

        private void ctentrycancel_Click(object sender, EventArgs e)
        {
            this.CTEntryPanel.Controls.Clear();
            CarTypeFrm CarTypeFrm_Vrb = new CarTypeFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            CarTypeFrm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.CTEntryPanel.Controls.Add(CarTypeFrm_Vrb);
            CarTypeFrm_Vrb.Show();
        }

        private void ctentryacc_Click(object sender, EventArgs e)
        {
            try
            {
                myCommand.CommandText = "insert into CarType values ('" + descentry.Text +
                    "'," + drateentry.Text + "," + wrateentry.Text + "," + mrateentry.Text + ")";
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }

            this.CTEntryPanel.Controls.Clear();
            CarTypeFrm CarTypeFrm_Vrb = new CarTypeFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            CarTypeFrm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.CTEntryPanel.Controls.Add(CarTypeFrm_Vrb);
            CarTypeFrm_Vrb.Show();


        }
    }
}
