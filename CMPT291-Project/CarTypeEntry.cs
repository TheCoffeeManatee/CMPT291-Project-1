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
using System.Globalization;

namespace CMPT291_Project
{
    public partial class CarTypeEntry : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        // state is used to track externally whether this object is being used to add/edit/remove
        // and entry (1), search an entry (2), or whether no operation is being performed (0)
        public int state = 0;
        // newCommand is used to consolidate the queries for the customers into the parent form
        // such that the query is assembled here and accessed by the parent form
        public string newCommand;
        private bool mouseDown;
        private Point lastLocation;

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
        
        // this changes the display to show only the id search when the appropriate radio
        // button is selected
        private void resetEditRemove()
        {
            FindID.Visible = true;
            CarTypeIdBx.Visible = true;
            CarTypeIdBx.Text = String.Empty;

            descentry.Visible = false;
            drateentry.Visible = false;
            wrateentry.Visible = false;
            mrateentry.Visible = false;
            LevelBx.Visible = false;
        }
        
        // this changes the display to show all of the entries and hide the id search box
        // when the appropriate radio buttons are selected
        private void resetAddSearch()
        {
            FindID.Visible = false;
            CarTypeIdBx.Visible = false;

            //ensures the text boxes are visible and empty
            descentry.Visible = true;
            drateentry.Visible = true;
            wrateentry.Visible = true;
            mrateentry.Visible = true;
            LevelBx.Visible = true;

            descentry.Text = String.Empty;
            drateentry.Text = String.Empty;
            wrateentry.Text = String.Empty;
            mrateentry.Text = String.Empty;
            LevelBx.Text = String.Empty;
        }

        private void ctentrycancel_Click_1(object sender, EventArgs e)
        {
            state = 0;
            this.Close();
        }
        
        // this function has different functionality depending on the selected radio button at the time
        // the user clicks accept
        private void ctentryacc_Click_1(object sender, EventArgs e)
        {
            
            if (AddRBtn.Checked == true) //adds car type to the database
            {
                // This check ensures that fields contain entries before a new item is added
                if (descentry.Text == "" || drateentry.Text == "" || wrateentry.Text ==  "" || mrateentry.Text == "")
                {
                    return;
                }
                if (!checkLevel() && int.TryParse(drateentry.Text, out int checkNum) && int.TryParse(wrateentry.Text, out checkNum) && int.TryParse(mrateentry.Text, out checkNum))
                {
                    MessageBox.Show("Ensure that all Rates and Level are numeric.", "Error");
                    return;
                }
                state = 1;
                newCommand = "insert into CarType values ('" + toCase(descentry.Text) +
                    "'," + drateentry.Text + "," + wrateentry.Text + "," + mrateentry.Text + ", " + LevelBx.Text + ")";
                this.Close();
            }

            else if (EditRBtn.Checked == true) //edits car type entry
            {
                // This check ensures that fields contain entries before a new item is added
                if (descentry.Text == "" || drateentry.Text == "" || wrateentry.Text == "" || mrateentry.Text == "")
                {
                    return;
                }
                if (!checkLevel() && int.TryParse(drateentry.Text, out int checkNum) && int.TryParse(wrateentry.Text, out checkNum) && int.TryParse(mrateentry.Text, out checkNum))
                {
                    MessageBox.Show("Ensure that all Rates and Level are numeric.", "Error");
                    return;
                }

                state = 1;
                newCommand = "update CarType Set Description = '" + toCase(descentry.Text) +
                    "', DailyRate = " + drateentry.Text + ", WeeklyRate = " + wrateentry.Text +
                    ", MonthlyRate = " + mrateentry.Text + ", Level = " + LevelBx.Text + " where CarTypeID = " + CarTypeIdBx.Text;
                this.Close();
            }

            else if (RemoveRBtn.Checked == true) //deletes car type entry
            {
                state = 1;
                newCommand = "delete from CarType where CarTypeId = " + CarTypeIdBx.Text;
                this.Close();
            }

            else if (SearchRBtn.Checked == true)
            {
                // first tracks whether " and " should be appended before the respective search term
                int first = 1;
                state = 2;
                newCommand = "select * from CarType where ";
                // the following set of statements ensure that only fields containing values are added
                // as search parameters
                if (descentry.Text != "")
                {
                    first = 0;
                    newCommand += "(Description like '%" + descentry.Text + "' or description like '" + descentry.Text + "%')";
                }
                if (drateentry.Text != "")
                {
                    if (first != 1)
                        newCommand += " and ";
                    else
                        first = 0;
                    newCommand += "DailyRate <= " + drateentry.Text;
                }
                if (wrateentry.Text != "")
                {
                    if (first != 1)
                        newCommand += " and ";
                    else
                        first = 0;
                    newCommand += "WeeklyRate <= "+ wrateentry.Text;
                }
                if (mrateentry.Text != "")
                {
                    if (first != 1)
                        newCommand += " and ";
                    else
                        first = 0;
                    newCommand += "MonthlyRate <= " + mrateentry.Text;
                }
                // if no search parameters are selected, this ensures that all customers are displayed
                if (first == 1)
                    newCommand = "select * from CarType";
                this.Close();
                
            }
        }
        
        // the following 4 functions change the display from the radio buttons
        private void AddRBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            resetAddSearch();
        }

        private void EditRBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            resetEditRemove();
        }

        private void RemoveRBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            resetEditRemove();
        }

        private void SearchRBtn_CheckedChanged(object sender, EventArgs e)
        {
            resetAddSearch();
        }
        
        // this function just gets the id entered into the field and populates the boxes with the
        // appropriate values
        private void FindID_Click_1(object sender, EventArgs e)
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

                    if (myReader.HasRows)
                    {
                        //saves variables read and displays them in the appropriate fields
                        while (myReader.Read())
                        {

                            string des = (string)myReader["Description"];
                            decimal dr = (decimal)myReader["DailyRate"];
                            decimal wr = (decimal)myReader["WeeklyRate"];
                            decimal mr = (decimal)myReader["MonthlyRate"];
                            int lvl = (int)myReader["Level"];

                            descentry.Visible = true;
                            drateentry.Visible = true;
                            wrateentry.Visible = true;
                            mrateentry.Visible = true;
                            LevelBx.Visible = true;

                            descentry.Text = des;
                            drateentry.Text = dr.ToString();
                            wrateentry.Text = wr.ToString();
                            mrateentry.Text = mr.ToString();
                            LevelBx.Text = lvl.ToString();
                        }

                    }

                    else
                    {
                        CarTypeIdBx.Text = string.Empty;

                        MessageBox.Show("Invalid Car Type ID", "Error");
                    }
                }

                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }
                myReader.Close();
            }

            else
                resetEditRemove();

        }
        bool checkLevel()
        {
            //converts string to integer 
            int level;
            bool success = int.TryParse(LevelBx.Text, out level);

            return success;
        }

        string toCase(string theString)
        {
            theString = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(theString.ToLower());
            return theString;
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
