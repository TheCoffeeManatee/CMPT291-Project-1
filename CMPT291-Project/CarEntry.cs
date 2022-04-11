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
        public int carTypeId, branchId;
       
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

            //fill carType combo box
            myCommand.CommandText = "select Description from CarType";
            myReader = myCommand.ExecuteReader();

            if (myReader.HasRows)
            {
                while (myReader.Read())
                {
                    CarTypePicker.Items.Add(myReader[0]);
                }
            }

            else
            {
                MessageBox.Show("Error Loading Car Types", "Error");
            }

            myReader.Close();

            //fill branch Id combo box
            myCommand.CommandText = "select Description from Branch";
            myReader = myCommand.ExecuteReader();

            if (myReader.HasRows)
            {
                while (myReader.Read())
                {
                    BranchPicker.Items.Add(myReader[0]);
                }
            }

            else
            {
                MessageBox.Show("Error Loading Branches", "Error");
            }

            myReader.Close();
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
                        "'," + carTypeId + ",'" + makeentry.Text + "','" + modelentry.Text + "'," + yearentry.Text + ","
                        + seatsentry.Text + ",'" + colourentry.Text + "','" + insentry.Text + "'," + mileentry.Text + ","
                        + branchId + ")";
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
                    myCommand.CommandText = "update Car set CarTypeId = " + carTypeId + ", Make = '" + makeentry.Text + "', Model = '" + modelentry.Text + "', Year = "
                        + yearentry.Text + ", Seats = " + seatsentry.Text + ", Colour = '" + colourentry.Text + "', Insurance = '" + insentry.Text + "', Odometer = " + mileentry.Text + ", BranchId = "
                        + branchId + "where VIN = " + vinentry.Text;
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
            CarTypePicker.Visible = true;
            makeentry.Visible = true;
            modelentry.Visible = true;
            yearentry.Visible = true;
            seatsentry.Visible = true; 
            colourentry.Visible = true;
            insentry.Visible = true;
            mileentry.Visible = true;
            BranchPicker.Visible = true;

            vinentry.Text = String.Empty;
            makeentry.Text = String.Empty;
            modelentry.Text = String.Empty;
            yearentry.Text = String.Empty;
            seatsentry.Text = String.Empty;
            colourentry.Text = String.Empty;
            insentry.Text = String.Empty;
            mileentry.Text = String.Empty;
        }

        private void resetEditRemove()
        {
            FindID.Visible = true;
            vinentry.Text = String.Empty;

            vinentry.Visible = true;
            CarTypePicker.Visible = false;
            makeentry.Visible = false;
            modelentry.Visible = false;
            yearentry.Visible = false;
            seatsentry.Visible = false;
            colourentry.Visible = false;
            insentry.Visible = false;
            mileentry.Visible = false;
            BranchPicker.Visible = false;
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
                    
                    if (myReader.HasRows)
                    { 
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
                        carTypeId = (int)myReader["CarTypeId"];
                        branchId = (int)myReader["BranchId"];


                        CarTypePicker.Visible = true;
                        makeentry.Visible = true;
                        modelentry.Visible = true;
                        yearentry.Visible = true;
                        seatsentry.Visible = true;
                        colourentry.Visible = true;
                        insentry.Visible = true;
                        mileentry.Visible = true;
                        BranchPicker.Visible = true;

                        vinentry.Text = vin;
                        makeentry.Text = mk;
                        modelentry.Text = mdl;
                        yearentry.Text = year.ToString();
                        seatsentry.Text = seat.ToString();
                        colourentry.Text = clr;
                        insentry.Text = ins.ToString();
                        mileentry.Text = miles.ToString();

                    }
                }

                else
                {
                    vinentry.Text = string.Empty;

                    MessageBox.Show("Invalid VIN", "Error");
                }
                myReader.Close();

                try
            {
                myCommand.CommandText = "select Description from Branch where BranchId = " + branchId;
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    currBranch.Text = "Current: " + (string)myReader["Description"];
                }
            }

            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
            myReader.Close();
                getBranch();
                getCarType();

            }
            catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }        
        }

        void getCarType()
        {
            try
            {
                myCommand.CommandText = "select Description from CarType where CarTypeId = " + carTypeId;
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    if (myReader.HasRows)
                    {
                        currCarType.Text = "Current: " + (string)myReader["Description"];
                    }
                }
            }

            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
            
            myReader.Close();

               
        }

        void getBranch()
        {
            try
            {
                myCommand.CommandText = "select Description from Branch where BranchId = " + branchId;
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    currBranch.Text = "Current: " + (string)myReader["Description"];
                }
            }

            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
            myReader.Close();

        }

        private void CarTypePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                myCommand.CommandText = "select CarTypeId from CarType where Description = '" + CarTypePicker.Text + "'";
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    if (myReader.HasRows)
                    {
                        carTypeId = (int)myReader["CarTypeId"];
                    }
                }
            }

            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }

            myReader.Close();
        }

        private void BranchPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                myCommand.CommandText = "select BranchId from Branch where Description = '" + BranchPicker.Text + "'";
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    if (myReader.HasRows)
                    {
                        branchId = (int)myReader["BranchId"];
                    }
                }
            }

            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }

            myReader.Close();
        }
    }
}
