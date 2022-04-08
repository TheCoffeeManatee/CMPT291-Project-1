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
            if (AddRBtn.Checked == true)
            {
                try
                {
                    myCommand.CommandText = "insert into Car values ('" + vinentry.Text +
                        "'," + typeentry.Text + ",'" + makeentry.Text + "','" + modelentry.Text + "'," + yearentry.Text + ","
                        + seatsentry.Text + ",'" + colourentry.Text + "','" + insentry.Text + "'," + mileentry.Text + ","
                        + branchentry.Text + ")";
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

            else if (EditRBtn.Checked == true)
            {
                try
                {
                    myCommand.CommandText = "update Car set VIN = '" + vinentry.Text +
                        "', CarTypeId = " + typeentry.Text + ", Make = " + makeentry.Text + ", Model = " + modelentry.Text + ", Year = " + yearentry.Text + ", Seats = "
                        + seatsentry.Text + ", Colour = " + colourentry.Text + ", Insurance = " + insentry.Text + ", Odometer = " + mileentry.Text + ", BranchId = "
                        + branchentry.Text;
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
            
            else if (RemoveRBtn.Checked == true)
            {
                try
                {
                    myCommand.CommandText = "delete from Car where VIN = " + vinentry.Text;
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
        }

        private void AddRBtn_CheckedChanged(object sender, EventArgs e)
        {
            FindID.Visible = false;

            vinentry.Visible = true;
            typeentry.Visible = true;
            makeentry.Visible = true;
            modelentry.Visible = true;
            yearentry.Visible = true;
            seatsentry.Visible = true; 
            colourentry.Visible = true;
            insentry.Visible = true;
            mileentry.Visible = true;
            branchentry.Visible = true;

            vinentry.Text = String.Empty;
            typeentry.Text = String.Empty;
            makeentry.Text = String.Empty;
            modelentry.Text = String.Empty;
            yearentry.Text = String.Empty;
            seatsentry.Text = String.Empty;
            colourentry.Text = String.Empty;
            insentry.Text = String.Empty;
            mileentry.Text = String.Empty;
            branchentry.Text = String.Empty;
        }

        private void resetEditRemove()
        {
            FindID.Visible = true;
            vinentry.Text = String.Empty;

            vinentry.Visible = true;
            typeentry.Visible = false;
            makeentry.Visible = false;
            modelentry.Visible = false;
            yearentry.Visible = false;
            seatsentry.Visible = false;
            colourentry.Visible = false;
            insentry.Visible = false;
            mileentry.Visible = false;
            branchentry.Visible = false;
        }
        private void EditRBtn_CheckedChanged(object sender, EventArgs e)
        {
            resetEditRemove();
        }

        private void RemoveRBtn_CheckedChanged(object sender, EventArgs e)
        {
            resetEditRemove();
        }


        private void FindID_Click(object sender, EventArgs e)
        {
                try
                {
                    myCommand.CommandText = "select * from Car where VIN = '" + vinentry.Text + "'";
                    myReader = myCommand.ExecuteReader();

                    //saves variables read and displays them in the appropriate fields
                    while (myReader.Read())
                    {

                        string vin = (string)myReader["VIN"];
                        int type = (int)myReader["CarTypeId"];
                        string mk = (string)myReader["Make"];
                        string mdl = (string)myReader["Model"];
                        int year = (int)myReader["Year"];
                        int seat = (int)myReader["Seats"];
                        string clr = (string)myReader["Colour"];
                        string ins = (string)myReader["Insurance"];
                        int miles = (int)myReader["Odometer"];
                        int bId = (int)myReader["BranchId"];

                        typeentry.Visible = true;
                        makeentry.Visible = true;
                        modelentry.Visible = true;
                        yearentry.Visible = true;
                        seatsentry.Visible = true;
                        colourentry.Visible = true;
                        insentry.Visible = true;
                        mileentry.Visible = true;
                        branchentry.Visible = true;

                        vinentry.Text = vin;
                        typeentry.Text = type.ToString();
                        makeentry.Text = mk;
                        modelentry.Text = mdl;
                        yearentry.Text = year.ToString();
                        seatsentry.Text = seat.ToString();
                        colourentry.Text = clr;
                        insentry.Text = ins.ToString();
                        mileentry.Text = miles.ToString();
                        branchentry.Text = bId.ToString();
                    }

                    myReader.Close();

                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
        
}        
        }
    }
}
