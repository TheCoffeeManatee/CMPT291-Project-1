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
    public partial class CustEntry : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        int mbr = 0;
        public int state = 0;
        public string dobStr, newCommand;

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

                            if (phone.Length == 10)
                                phoneentry.Text = "(" + phone[0] + phone[1] + phone[2] + ") " + phone[3] + phone[4] + phone[5] + "-" + phone[6] + phone[7] + phone[8] + phone[9];

                            else if (phone.Length == 11)
                                phoneentry.Text = phone[0] + "(" + phone[1] + phone[2] + phone[3] + ") " + phone[4] + phone[5] + phone[6] + "-" + phone[7] + phone[8] + phone[9] + phone[10];


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

        private void custentryacc_Click_1(object sender, EventArgs e)
        {
            if (AddRBtn.Checked == true)
            {
                string phoneNumber = parsePhone(phoneentry.Text);
                state = 1;
                dobStr = DOBEntry.Value.ToString();

                newCommand = "insert into Customer values ('" + fnameentry.Text +
                    "','" + mnameentry.Text + "','" + lnameentry.Text + "','" + add1entry.Text +
                    "','" + add2entry.Text + "','" + cityentry.Text + "','" + proventry.Text + "','" +
                    postalentry.Text + "','" + dobStr + "'," + phoneNumber + ",'" + cinsentry.Text
                    + "','" + dlentry.Text + "'," + mbr + ")";
                this.Close();
            }

            else if (EditRBtn.Checked == true)
            {
                state = 1;
                string phoneNumber = parsePhone(phoneentry.Text);
                dobStr = DOBEntry.Value.ToString();

                newCommand = "update Customer set FirstName = '" + fnameentry.Text +
                    "', MIddleName = '" + mnameentry.Text + "', LastName = '" + lnameentry.Text + "', StreetAddress1 = '" + add1entry.Text +
                    "', StreetAddress2 = '" + add2entry.Text + "', City = '" + cityentry.Text + "', Province = '" + proventry.Text + "', PostalCode = '" +
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
                int first = 1;
                state = 2;
                newCommand = "select * from Customer where ";
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
                    if (first != 1)
                        newCommand += " and ";
                    else
                        first = 0;
                    newCommand += "DOB like '" + DOBEntry.Value.Year + "-" + DOBEntry.Value.Month + "-" + DOBEntry.Value.Day + "'";
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


        string parsePhone(string phone)
        {
            string newPhone = "";

            for (int i = 0; i < phone.Length; i++)
                if (Char.IsDigit(phone[i]))
                    newPhone += phone[i];

            return newPhone;
        }
    }
}
