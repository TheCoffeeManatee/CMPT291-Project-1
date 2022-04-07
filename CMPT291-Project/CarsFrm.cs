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

        public CarsFrm()
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.CarsPanel.Controls.Clear();
            CarEntry CarEntry_Vrb = new CarEntry() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            CarEntry_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.CarsPanel.Controls.Add(CarEntry_Vrb);
            CarEntry_Vrb.Show();
        }
    }
}
