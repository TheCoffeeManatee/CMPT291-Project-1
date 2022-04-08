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
            AddRBtn.Checked = true;

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
            if (AddRBtn.Checked == true) //adds car type to the database
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

            else if (EditRBtn.Checked == true) //edits car type entry
            {
                try
                {
                    myCommand.CommandText = "update CarType Set Description = '" + descentry.Text +
                        "', DailyRate = " + drateentry.Text + ", WeeklyRate = " + wrateentry.Text + 
                        ", MonthlyRate = " + mrateentry.Text + " where CarTypeID = " + CarTypeIdBx.Text;
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

            else if (RemoveRBtn.Checked == true) //deletes car type entry
            {
                try
                {
                    myCommand.CommandText = "delete from CarType where CarTypeId = " + CarTypeIdBx.Text;
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

        //resets form for adding
        private void AddRBtn_CheckedChanged(object sender, EventArgs e)
        {
            FindID.Visible = false;
            CarTypeIdBx.Visible = false;

            //ensures the text boxes are visible and empty
            descentry.Visible = true;
            drateentry.Visible = true;
            wrateentry.Visible = true;
            mrateentry.Visible = true;

            descentry.Text = String.Empty;
            drateentry.Text = String.Empty;
            wrateentry.Text = String.Empty;
            mrateentry.Text = String.Empty;
        }

        //resets form for editing
        private void EditRBtn_CheckedChanged(object sender, EventArgs e)
        {
            resetEditRemove();

        }

        //resets form for removing
        private void RemoveRBtn_CheckedChanged(object sender, EventArgs e)
        {
            resetEditRemove();
        }

        private void resetEditRemove()
        {
            FindID.Visible = true;
            CarTypeIdBx.Visible = true;
            CarTypeIdBx.Text = String.Empty;

            descentry.Visible = false;
            drateentry.Visible = false;
            wrateentry.Visible = false;
            mrateentry.Visible = false;
        }

        private void FindID_Click(object sender, EventArgs e) //find the ID entered and display the information
        {
            //converts string to integer 
            int displayID;
            bool success = int.TryParse(CarTypeIdBx.Text, out displayID);

            if (success)
            {
                try
                {
                    myCommand.CommandText = "select * from CarType where CarTypeId = " + displayID;
                    myReader = myCommand.ExecuteReader();
                    
                    //saves variables read and displays them in the appropriate fields
                    while(myReader.Read())
                    {

                        string des = (string)myReader["Description"];
                        decimal dr = (decimal)myReader["DailyRate"];
                        decimal wr = (decimal)myReader["WeeklyRate"];
                        decimal mr = (decimal)myReader["MonthlyRate"];

                        descentry.Visible = true;
                        drateentry.Visible = true;
                        wrateentry.Visible = true;
                        mrateentry.Visible = true;

                        descentry.Text = des;
                        drateentry.Text = dr.ToString();
                        wrateentry.Text = wr.ToString();
                        mrateentry.Text = mr.ToString();
                    }

                    myReader.Close();

                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }

            }

            else
            {
                resetEditRemove();
            }
        }
    }
}
