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
    public partial class TransSearch : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public string newCommand;
        public int state = 0;
        private bool mouseDown;
        private Point lastLocation;

        public TransSearch()
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
            //fill branch combo boxes
            myCommand.CommandText = "select BranchId from Branch";
            myReader = myCommand.ExecuteReader();
            if (myReader.HasRows)
            {
                while(myReader.Read())
                {
                    PBranchPicker.Items.Add(myReader[0]);
                    RBranchPicker.Items.Add(myReader[0]);
                }
            }
            else
            {
                MessageBox.Show("Error Loading Branches", "Error");
            }
            myReader.Close();
            //fill cartype combo box
            myCommand.CommandText = "select CarTypeId from CarType";
            myReader = myCommand.ExecuteReader();
            if(myReader.HasRows)
            {
                while(myReader.Read())
                {
                    CarTypePicker.Items.Add(myReader[0]);
                }
            }
            else
            {
                MessageBox.Show("Error Loading Car Types", "Error");
            }
            myReader.Close();
        }

        private void TSearchCancel_Click(object sender, EventArgs e)
        {
            state = 0;
            this.Close();
        }

        private void TSearchAccept_Click(object sender, EventArgs e)
        {
            state = 1;
            int first = 1;
            newCommand = "select * from Rentals where ";
            if (ridentry.Text != "")
            {
                first = 0;
                newCommand += "RentalId = " + ridentry.Text;
            }
            if (PBranchPicker.Text != "")
            {
                if (first != 1)
                    newCommand += " and ";
                else
                    first = 0;
                newCommand += "PickupBranch = " + PBranchPicker.Text;
            }
            if (PDateCheck.Checked)
            {
                string phM = "", phD = "";
                if (first != 1)
                    newCommand += " and ";
                else
                    first = 0;
                if (PDateEntry.Value.Month < 10)
                    phM += "0";
                if (PDateEntry.Value.Day < 10)
                    phD += "0";
                newCommand += "PickupDate like '" + PDateEntry.Value.Year + "-" + phM + PDateEntry.Value.Month + "-" + phD + PDateEntry.Value.Day + "'";
            }

            if (RDateCheck.Checked)
            {
                string phM = "", phD = "";
                if (first != 1)
                    newCommand += " and ";
                else
                    first = 0;
                if (RDateEntry.Value.Month < 10)
                    phM += "0";
                if (RDateEntry.Value.Day < 10)
                    phD += "0";
                newCommand += "PickupDate like '" + RDateEntry.Value.Year + "-" + phM + RDateEntry.Value.Month + "-" + phD + RDateEntry.Value.Day + "'";
            }

            if (RBranchPicker.Text != "")
            {
                if (first != 1)
                    newCommand += " and ";
                else
                    first = 0;
                newCommand += "ReturnBranch = " + RBranchPicker.Text;
            }

            if (CarTypePicker.Text != "")
            {
                if (first != 1)
                    newCommand += " and ";
                else
                    first = 0;
                newCommand += "CarTypeId = " + CarTypePicker.Text;
            }
            if (cidentry.Text != "")
            {
                if (first != 1)
                    newCommand += " and ";
                else
                    first = 0;
                newCommand += "CustomerId = " + cidentry.Text;
            }
            if (vinentry.Text != "")
            {
                if (first != 1)
                    newCommand += " and ";
                else
                    first = 0;
                newCommand += "(VIN like '%" + vinentry.Text + "' or VIN like '" + vinentry.Text + "%')";
            }
            if (priceentry.Text != "")
            {
                if (first != 1)
                    newCommand += " and ";
                else
                    first = 0;
                newCommand += "((Price - " + priceentry.Text + ") < 50 and (Price - " + priceentry.Text + ") > -50)";
            }
            if (latecheck.Checked)
            {
                if (first != 1)
                    newCommand += " and ";
                else
                    first = 0;
                newCommand += "Late = 1";
            }
            if (first == 1)
                newCommand = "select * from Rentals";
            this.Close();
        }

        private void MenuBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MenuBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void MenuBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaxBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                MaxBtn.BackgroundImage = new Bitmap(CMPT291_Project.Properties.Resources.MIN);
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                MaxBtn.BackgroundImage = new Bitmap(CMPT291_Project.Properties.Resources.MAX);
            }
        }

        private void ExtBtn_Click(object sender, EventArgs e)
        {
            state = 0;
            this.Close();
        }
    }
}
