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
    public partial class CustEntry : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        // mbr tracks membership status
        int mbr = 0;
        // state is used to track externally whether this object is being used to add/edit/remove
        // and entry (1), search an entry (2), or whether no operation is being performed (0)
        public int state = 0;
        // newCommand is used to consolidate the queries for the customers into the parent form
        // such that the query is assembled here and accessed by the parent form
        public string dobStr, newCommand;
        private bool mouseDown;
        private Point lastLocation;

        public CustEntry()
        {
            InitializeComponent();
            AddRBtn.Checked = true;
            mementry.Checked = false;

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
            CustIdBx.Visible = true;

            fnameentry.Visible = false;
            mnameentry.Visible = false;
            lnameentry.Visible = false;
            add1entry.Visible = false;
            add2entry.Visible = false;
            cityentry.Visible = false;
            proventry.Visible = false;
            postalentry.Visible = false;
            DOBEntry.Visible = false;
            phoneentry.Visible = false;
            cinsentry.Visible = false;
            dlentry.Visible = false;
            mementry.Visible = false;
        }

        // this changes the display to show all of the entries and hide the id search box
        // when the appropriate radio buttons are selected
        private void resetAddSearch()
        {
            FindID.Visible = false;
            CustIdBx.Visible = false;

            //ensures the text boxes are visible and empty
            fnameentry.Visible = true;
            mnameentry.Visible = true;
            lnameentry.Visible = true;
            add1entry.Visible = true;
            add2entry.Visible = true;
            cityentry.Visible = true;
            proventry.Visible = true;
            postalentry.Visible = true;
            DOBEntry.Visible = true;
            phoneentry.Visible = true;
            cinsentry.Visible = true;
            dlentry.Visible = true;
            mementry.Visible = true;

            fnameentry.Text = String.Empty;
            mnameentry.Text = String.Empty;
            lnameentry.Text = String.Empty;
            add1entry.Text = String.Empty;
            add2entry.Text = String.Empty;
            cityentry.Text = String.Empty;
            proventry.Text = String.Empty;
            postalentry.Text = String.Empty;
            phoneentry.Text = String.Empty;
            cinsentry.Text = String.Empty;
            dlentry.Text = String.Empty;
            mementry.Checked = false;
        }


        private void mementry_CheckedChanged_1(object sender, EventArgs e)
        {
            if (mementry.Checked)
                mbr = 1;
            else
                mbr = 0;
        }

        // this function just gets the id entered into the field and populates the boxes with the
        // appropriate values
        private void FindID_Click_1(object sender, EventArgs e)
        {
            //converts string to integer 
            int displayID;
            bool success = int.TryParse(CustIdBx.Text, out displayID);

            if (success)
            {
                try
                {
                    myCommand.CommandText = "select * from Customer where CustomerId  = " + displayID;
                    myReader = myCommand.ExecuteReader();

                    if (myReader.HasRows)
                    {
                        //saves variables read and displays them in the appropriate fields
                        while (myReader.Read())
                        {

                            string fname = (string)myReader["FirstName"];
                            string mname = (string)myReader["MiddleName"];
                            string lname = (string)myReader["LastName"];
                            string add1 = (string)myReader["StreetAddress1"];
                            string add2 = (string)myReader["StreetAddress2"];
                            string city = (string)myReader["City"];
                            string prov = (string)myReader["Province"];
                            string post = (string)myReader["PostalCode"];
                            var dob = myReader["DOB"];
                            string phone = (string)myReader["Phone"];
                            string ins = (string)myReader["Insurance"];
                            string dl = (string)myReader["DrivingLicense"];
                            int mem = (int)myReader["Membership"];

                            fnameentry.Visible = true;
                            mnameentry.Visible = true;
                            lnameentry.Visible = true;
                            add1entry.Visible = true;
                            add2entry.Visible = true;
                            cityentry.Visible = true;
                            proventry.Visible = true;
                            postalentry.Visible = true;
                            DOBEntry.Visible = true;
                            phoneentry.Visible = true;
                            cinsentry.Visible = true;
                            dlentry.Visible = true;

                            fnameentry.Text = fname;
                            mnameentry.Text = mname;
                            lnameentry.Text = lname;
                            add1entry.Text = add1;
                            add2entry.Text = add2;
                            cityentry.Text = city;
                            proventry.Text = prov;
                            postalentry.Text = post;
                            DOBEntry.Value = Convert.ToDateTime(dob);
                            cinsentry.Text = ins;
                            dlentry.Text = dl;
                            phoneentry.Text = phone;

                            mementry.Visible = true;
                            if (mem == 1)
                            {
                                mementry.Checked = true;
                            }
                            else
                            {
                                mementry.Checked = false;
                            }

                        }

                        myReader.Close();
                    }

                    else
                    {
                        CustIdBx.Text = string.Empty;

                        MessageBox.Show("Invalid Customer ID", "Error");
                    }

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
        // the following 4 functions change the display from the radio buttons
        private void RemoveRBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            resetEditRemove();
        }

        private void EditRBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            resetEditRemove();
        }

        private void AddRBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            resetAddSearch();
        }

        private void SearchRBtn_CheckedChanged(object sender, EventArgs e)
        {
            resetAddSearch();
        }
        
        // this function has different functionality depending on the selected radio button at the time
        // the user clicks accept
        private void custentryacc_Click_1(object sender, EventArgs e)
        {
            if (AddRBtn.Checked == true)
            {
                // This check ensures that fields contain entries before a new item is added
                if (fnameentry.Text == ""|| mnameentry.Text == "" || lnameentry.Text == ""||add1entry.Text == ""||add2entry.Text==""||
                    cityentry.Text == ""||proventry.Text==""||postalentry.Text == ""||cinsentry.Text == ""||dlentry.Text == "")
                {
                    return;
                }
                string phoneNumber = parsePhone(phoneentry.Text);
                state = 1;
                dobStr = DOBEntry.Value.ToString();

                newCommand = "insert into Customer values ('" + toCase(fnameentry.Text) +
                    "','" + toCase(mnameentry.Text) + "','" + toCase(lnameentry.Text) + "','" + toCase(add1entry.Text) +
                    "','" + toCase(add2entry.Text) + "','" + toCase(cityentry.Text) + "','" + toCase(proventry.Text) + "','" +
                    postalentry.Text + "','" + dobStr + "'," + phoneNumber + ",'" + cinsentry.Text
                    + "','" + dlentry.Text + "'," + mbr + ")";
                this.Close();
            }

            else if (EditRBtn.Checked == true)
            {
                // This check ensures that fields contain entries before a new item is added
                if (fnameentry.Text == "" || mnameentry.Text == "" || lnameentry.Text == "" || add1entry.Text == "" || add2entry.Text == "" ||
                    cityentry.Text == "" || proventry.Text == "" || postalentry.Text == "" || cinsentry.Text == "" || dlentry.Text == "")
                {
                    return;
                }
                state = 1;
                string phoneNumber = parsePhone(phoneentry.Text);
                dobStr = DOBEntry.Value.ToString();

                newCommand = "update Customer set FirstName = '" + toCase(fnameentry.Text) +
                    "', MiddleName = '" + toCase(mnameentry.Text) + "', LastName = '" + toCase(lnameentry.Text) + "', StreetAddress1 = '" + add1entry.Text +
                    "', StreetAddress2 = '" + toCase(add2entry.Text) + "', City = '" + toCase(cityentry.Text) + "', Province = '" + toCase(proventry.Text) + "', PostalCode = '" +
                    postalentry.Text + "', DOB = '" + dobStr + "', Phone = '" + phoneNumber + "', Insurance = '" + cinsentry.Text
                    + "', DrivingLicense = '" + dlentry.Text + "', Membership = " + mbr + "where CustomerId = " + CustIdBx.Text;
                this.Close();
            }

            else if (RemoveRBtn.Checked == true)
            {
                state = 1;
                newCommand = "delete from Customer where CustomerId = " + CustIdBx.Text;
                this.Close();
            }

            else if (SearchRBtn.Checked == true)
            {
                // first tracks whether " and " should be appended before the respective search term
                int first = 1;
                state = 2;
                newCommand = "select * from Customer where ";
                // the following set of statements ensure that only fields containing values are added
                // as search parameters
                if (fnameentry.Text != "")
                {
                    first = 0;
                    newCommand += "(FirstName like '%" + fnameentry.Text + "' or FirstName like '" + fnameentry.Text + "%')";
                }
                if (mnameentry.Text != "")
                {
                    if (first != 1)
                        newCommand += " and ";
                    else
                        first = 0;
                    newCommand += "(MiddleName like '%" + mnameentry.Text + "' or MiddleName like '" + mnameentry.Text + "%')";
                }
                if (lnameentry.Text != "")
                {
                    if (first != 1)
                        newCommand += " and ";
                    else
                        first = 0;
                    newCommand += "(LastName like '%" + lnameentry.Text + "' or LastName like '" + lnameentry.Text + "%')";
                }
                if (add1entry.Text != "")
                {
                    if (first != 1)
                        newCommand += " and ";
                    else
                        first = 0;
                    newCommand += "(StreetAddress1 like '%" + add1entry.Text + "' or StreetAddress1 like '" + add1entry.Text + "%')";
                }
                if (add2entry.Text != "")
                {
                    if (first != 1)
                        newCommand += " and ";
                    else
                        first = 0;
                    newCommand += "(StreetAddress2 like '%" + add2entry.Text + "' or StreetAddress2 like '" + add2entry.Text + "%')";
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
                if (DOBEntry.Value.Date < DateTime.Today)
                {
                    string phM = "", phD = "";
                    if (first != 1)
                        newCommand += " and ";
                    else
                        first = 0;
                    // these next if statements ensure that lower digit date values compare correctly with their sql counterparts
                    if (DOBEntry.Value.Month < 10)
                        phM += "0";
                    if (DOBEntry.Value.Day < 10)
                        phD += "0";
                    newCommand += "DOB like '" + DOBEntry.Value.Year + "-"+ phM + DOBEntry.Value.Month + "-" + phD + DOBEntry.Value.Day + "'";
                }
                if (phoneentry.Text != "")
                {
                    if (first != 1)
                        newCommand += " and ";
                    else
                        first = 0;
                    newCommand += "(Phone like '%" + phoneentry.Text + "' or Phone like '" + phoneentry.Text + "%')";
                }
                if (cinsentry.Text != "")
                {
                    if (first != 1)
                        newCommand += " and ";
                    else
                        first = 0;
                    newCommand += "(Insurance like '%" + cinsentry.Text + "' or Insurance like '" + cinsentry.Text + "%')";
                }
                if (dlentry.Text != "")
                {
                    if (first != 1)
                        newCommand += " and ";
                    else
                        first = 0;
                    newCommand += "(DrivingLicense like '%" + dlentry.Text + "' or DrivingLicense like '" + dlentry.Text + "%')";
                }
                if (mementry.Checked)
                {
                    if (first != 1)
                        newCommand += " and ";
                    else
                        first = 0;
                    newCommand += "Membership = 1";
                }
                // if no search parameters are selected, this ensures that all customers are displayed
                if (first == 1)
                    newCommand = "select * from Customer";
                this.Close();
            }
        }

        private void custentrycancel_Click_1(object sender, EventArgs e)
        {
            state = 0;
            this.Close();
        }

        // this ensures that formatting for phone matches its sql counterpart
        string parsePhone(string phone)
        {
            string newPhone = "";

            for (int i = 0; i < phone.Length; i++)
                if (Char.IsDigit(phone[i]))
                    newPhone += phone[i];

            return newPhone;
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

        string toCase(string theString)
        {
            theString = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(theString.ToLower());
            return theString;
        }
    }
}
