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
        public string dobStr;

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

        private void custentrycancel_Click(object sender, EventArgs e)
        {
            this.CustEntryPanel.Controls.Clear();
            CustomersFrm CustomersFrm_Vrb = new CustomersFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            CustomersFrm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.CustEntryPanel.Controls.Add(CustomersFrm_Vrb);
            CustomersFrm_Vrb.Show();
        }

        private void custentryacc_Click(object sender, EventArgs e)
        {
            if (AddRBtn.Checked == true)
            {
                try
                {
                    dobStr = DOBEntry.Value.ToString();

                    myCommand.CommandText = "insert into Customer values ('" + fnameentry.Text +
                        "','" + mnameentry.Text + "','" + lnameentry.Text + "','" + add1entry.Text +
                        "','" + add2entry.Text + "','" + cityentry.Text + "','" + proventry.Text + "','" +
                        postalentry.Text + "','" + dobStr + "'," + phoneentry.Text + ",'" + cinsentry.Text
                        + "','" + dlentry.Text + "'," + mbr + ")";
                    myCommand.ExecuteNonQuery();
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }

                this.CustEntryPanel.Controls.Clear();
                CustomersFrm CustomersFrm_Vrb = new CustomersFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                CustomersFrm_Vrb.FormBorderStyle = FormBorderStyle.None;
                this.CustEntryPanel.Controls.Add(CustomersFrm_Vrb);
                CustomersFrm_Vrb.Show();
            }

            else if (EditRBtn.Checked == true)
            {
                try
                {
                    dobStr = DOBEntry.Value.ToString();

                    myCommand.CommandText = "update Customer set FirstName = '" + fnameentry.Text +
                        "', MIddleName = '" + mnameentry.Text + "', LastName = '" + lnameentry.Text + "', StreetAddress1 = '" + add1entry.Text +
                        "', StreetAddress2 = '" + add2entry.Text + "', City = '" + cityentry.Text + "', Province = '" + proventry.Text + "', PostalCode = '" +
                        postalentry.Text + "', DOB = '" + dobStr + "', Phone = '" + phoneentry.Text + "', Insurance = '" + cinsentry.Text
                        + "', DrivingLicense = '" + dlentry.Text + "', Membership = " + mbr;
                    myCommand.ExecuteNonQuery();
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }

                this.CustEntryPanel.Controls.Clear();
                CustomersFrm CustomersFrm_Vrb = new CustomersFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                CustomersFrm_Vrb.FormBorderStyle = FormBorderStyle.None;
                this.CustEntryPanel.Controls.Add(CustomersFrm_Vrb);
                CustomersFrm_Vrb.Show();
            }

            else if (RemoveRBtn.Checked == true)
            {
                try
                {
                    myCommand.CommandText = "delete from Customer where CustomerId = " + CustIdBx.Text;
                    myCommand.ExecuteNonQuery();
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }

                this.CustEntryPanel.Controls.Clear();
                CustomersFrm CustomersFrm_Vrb = new CustomersFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                CustomersFrm_Vrb.FormBorderStyle = FormBorderStyle.None;
                this.CustEntryPanel.Controls.Add(CustomersFrm_Vrb);
                CustomersFrm_Vrb.Show();
            }
        }

        private void AddRBtn_CheckedChanged(object sender, EventArgs e)
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

        private void EditRBtn_CheckedChanged(object sender, EventArgs e)
        {
            resetEditRemove();
        }

        private void RemoveRBtn_CheckedChanged(object sender, EventArgs e)
        {
            resetEditRemove();
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

        private void FindID_Click(object sender, EventArgs e)
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
                            phoneentry.Text = phone;
                            cinsentry.Text = ins;
                            dlentry.Text = dl;

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

        private void mementry_CheckedChanged(object sender, EventArgs e)
        {
            if (mementry.Checked)
                mbr = 1;
            else
                mbr = 0;
        }
    }
}
