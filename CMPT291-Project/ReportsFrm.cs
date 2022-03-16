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

namespace CMPT291_Project
{
    public partial class ReportsFrm : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myDataReader;
        public ReportsFrm()
        {
            InitializeComponent();
            String connectionString = "Server = DESKTOP-KCPC9PN; Database = LabProjectTest; Trusted_Connection = True;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();  
            }
        }

        private void ReportUpdate1_Click(object sender, EventArgs e)
        {
            string d1 = DatePick1.Value.ToString("yyyy-MM-dd");
            string d2 = DatePick2.Value.ToString("yyyy-MM-dd");
            Date1.Text = d1;
            Date1.Visible = true;
            Date2.Text = d2;
            Date2.Visible = true;
            myCommand.CommandText = "select Car.VIN, CarType.Description, CarType.DailyRate, CarType.MonthlyRate, Rentals.Price from Car, CarType, Rentals where Car.VIN = Rentals.VIN and Rentals.CarTypeId = CarType.CarTypeId";
            try
            {
                MessageBox.Show(myCommand.CommandText);
                myDataReader = myCommand.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (myDataReader.Read())
                {
                    dataGridView1.Rows.Add(myDataReader["VIN"].ToString(), myDataReader["Description"].ToString(), myDataReader["DailyRate"].ToString(), myDataReader["MonthlyRate"].ToString(), myDataReader["Price"].ToString());
                }
                myDataReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
                myDataReader.Close();
            }
        }   

        private void UpdateReport2_Click(object sender, EventArgs e)
        {
            string d3 = DatePick3.Value.ToString("yyyy/MM/dd");
            string d4 = DatePick4.Value.ToString("yyyy/MM/dd");
            Date3.Text = d3;
            Date3.Visible = true;
            Date4.Text = d4;
            Date4.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
