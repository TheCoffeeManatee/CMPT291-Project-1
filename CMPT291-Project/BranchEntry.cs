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
    public partial class BranchEntry : Form
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

        public BranchEntry()
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
        private void resetRemoveEdit()
        {
            FindID.Visible = true;
            BranchIdBx.Visible = true;
            BranchIdBx.Text = String.Empty;

            descentry.Visible = false;
            addL1entry.Visible = false;
            addL2Entry.Visible = false;
            cityentry.Visible = false;
            proventry.Visible = false;
            postalentry.Visible = false;
            phoneentry.Visible = false;
        }
        // this changes the display to show all of the entries and hide the id search box
        // when the appropriate radio buttons are selected
        private void resetAddSearch()
        {
            FindID.Visible = false;
            BranchIdBx.Visible = false;

            //ensures the text boxes are visible and empty
            descentry.Visible = true;
            addL1entry.Visible = true;
            addL2Entry.Visible = true;
            cityentry.Visible = true;
            proventry.Visible = true;
            postalentry.Visible = true;
            phoneentry.Visible = true;

            descentry.Text = String.Empty;
            addL1entry.Text = String.Empty;
            addL2Entry.Text = String.Empty;
            cityentry.Text = String.Empty;
            proventry.Text = String.Empty;
            postalentry.Text = String.Empty;
            phoneentry.Text = String.Empty;
        }

        string parsePhone(string phone)
        {
            string newPhone = "";

            for (int i = 0; i < phone.Length; i++)
                if (Char.IsDigit(phone[i]))
                    newPhone += phone[i];

            return newPhone;
        }

        private void branchcancel_Click_1(object sender, EventArgs e)
        {
            state = 0;
            this.Close();
        }
        // this function has different functionality depending on the selected radio button at the time
        // the user clicks accept
        private void Branchaccept_Click(object sender, EventArgs e)
        {
            if (AddRBtn.Checked == true) //adds branch
            {
                // This check ensures that fields contain entries before a new item is added
                if (addL1entry.Text == "" || addL2Entry.Text == "" || cityentry.Text == "" || proventry.Text == "" || postalentry.Text == "" || phoneentry.Text == "")
                {
                    return;
                }
                state = 1;
                string phoneNumber = parsePhone(phoneentry.Text);

                newCommand = "insert into Branch values ('" + descentry.Text +
                    "','" + addL1entry.Text + "','" + addL2Entry.Text + "','" + cityentry.Text + "','"
                    + proventry.Text + "','" + postalentry.Text + "'," + phoneNumber + ")";

                this.Close();
            }

            else if (EditRBtn.Checked == true) //edits branch
            {
                // This check ensures that fields contain entries before a new item is added
                if (addL1entry.Text == "" || addL2Entry.Text == "" || cityentry.Text == "" || proventry.Text == "" || postalentry.Text == "" || phoneentry.Text == "")
                {
                    return;
                }
                state = 1;
                string phoneNumber = parsePhone(phoneentry.Text);

                newCommand = "update Branch set Description = " + descentry.Text +
                    ", StreetAddress1 = " + addL1entry.Text + ", StreetAddress2 = " + addL2Entry.Text +
                    ", City = " + cityentry.Text + ", Province = " + proventry.Text + ", PostalCode = " + postalentry.Text +
                    ", Phone = " + phoneNumber + " where BranchID = " + BranchIdBx.Text;

                this.Close();
            }

            else if (RemoveRBtn.Checked == true) //deletes branch
            {
                state = 1;
                newCommand = "delete from Branch where BranchId = " + BranchIdBx.Text;
                this.Close();
            }

            else if (SearchRBtn.Checked == true)
            {
                // first tracks whether " and " should be appended before the respective search term
                int first = 1;
                state = 2;
                newCommand = "select * from Branch where ";
                // the following set of statements ensure that only fields containing values are added
                // as search parameters
                if (BranchIdBx.Text != "")
                {
                    first = 0;
                    newCommand += "BranchId = " + BranchIdBx.Text;
                }
                if (addL1entry.Text != "")
                {
                    if (first != 1)
                        newCommand += " and ";
                    else
                        first = 0;
                    newCommand += "(StreetAddress1 like '%" + addL1entry.Text + "' or StreetAddress1 like '" + addL1entry.Text + "%')";
                }
                if (addL2Entry.Text != "")
                {
                    if (first != 1)
                        newCommand += " and ";
                    else
                        first = 0;
                    newCommand += "(StreetAddress2 like '%" + addL2Entry.Text + "' or StreetAddress2 like '" + addL2Entry.Text + "%')";
                }
                if (cityentry.Text != "")
                {
                    if (first != 1)
                        newCommand += " and ";
                    else
                        first = 0;
                    newCommand += "(City like '%" + cityentry.Text + "' or City like '" + cityentry.Text + "%')";
                }
                if (proventry.Text != "")
                {
                    if (first != 1)
                        newCommand += " and ";
                    else
                        first = 0;
                    newCommand += "(Province like '%" + proventry.Text + "' or Province like '" + proventry.Text + "%')";
                }
                if (postalentry.Text != "")
                {
                    if (first != 1)
                        newCommand += " and ";
                    else
                        first = 0;
                    newCommand += "(PostalCode like '%" + postalentry.Text + "' or PostalCode like '" + postalentry.Text + "%')";
                }
                if (phoneentry.Text != "")
                {
                    if (first != 1)
                        newCommand += " and ";
                    else
                        first = 0;
                    newCommand += "(Phone like '%" + phoneentry.Text + "' or Phone like '" + phoneentry.Text + "%')";
                }
                // if no search parameters are selected, this ensures that all customers are displayed
                if (first == 1)
                    newCommand = "select * from Branch";
                this.Close();
            }
        }
        // the following 4 functions change the display from the radio buttons
        private void AddRBtn_CheckedChanged(object sender, EventArgs e)
        {
            resetAddSearch();
        }

        private void EditRBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            resetRemoveEdit();
        }

        private void RemoveRBtn_CheckedChanged(object sender, EventArgs e)
        {
            resetRemoveEdit();
        }
        private void SearchRBtn_CheckedChanged(object sender, EventArgs e)
        {
            resetAddSearch();
        }
        // this function just gets the id entered into the field and populates the boxes with the
        // appropriate values
        private void FindID_Click(object sender, EventArgs e)
        {
            {
                //converts string to integer 
                int displayID;
                bool success = int.TryParse(BranchIdBx.Text, out displayID);

                if (success)
                {
                    try
                    {
                        myCommand.CommandText = "select * from Branch where BranchId = " + displayID;
                        myReader = myCommand.ExecuteReader();


                        if (myReader.HasRows)
                        {
                            //saves variables read and displays them in the appropriate fields
                            while (myReader.Read())
                            {

                                string des = (string)myReader["Description"];
                                string addL1 = (string)myReader["StreetAddress1"];
                                string addL2 = (string)myReader["StreetAddress2"];
                                string city = (string)myReader["City"];
                                string prov = (string)myReader["Province"];
                                string postal = (string)myReader["PostalCode"];
                                string phone = (string)myReader["Phone"];

                                descentry.Visible = true;
                                addL1entry.Visible = true;
                                addL2Entry.Visible = true;
                                cityentry.Visible = true;
                                proventry.Visible = true;
                                postalentry.Visible = true;
                                phoneentry.Visible = true;

                                descentry.Text = des;
                                addL1entry.Text = addL1.ToString();
                                addL2Entry.Text = addL2.ToString();
                                cityentry.Text = city.ToString();
                                proventry.Text = prov.ToString();
                                postalentry.Text = postal.ToString();
                                 phoneentry.Text = phone;
                            }

                            myReader.Close();
                        }

                        else
                        {
                            BranchIdBx.Text = string.Empty;

                            MessageBox.Show("Invalid Branch ID", "Error");
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

        private void descentry_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
