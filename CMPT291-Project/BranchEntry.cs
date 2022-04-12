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
        public int state = 0;
        public string newCommand;

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

        private void Branchaccept_Click(object sender, EventArgs e)
        {
            if (AddRBtn.Checked == true) //adds branch
            {
                string phoneNumber = parsePhone(phoneentry.Text);

                try
                {
                    myCommand.CommandText = "insert into Branch values ('" + descentry.Text +
                        "','" + addL1entry.Text + "','" + addL2Entry.Text + "','" + cityentry.Text + "','"
                        + proventry.Text + "','" + postalentry.Text + "'," + phoneNumber + ")";
                    myCommand.ExecuteNonQuery();
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }

                this.Close();
            }

            else if (EditRBtn.Checked == true) //edits branch
            {
                string phoneNumber = parsePhone(phoneentry.Text);

                try
                {
                    myCommand.CommandText = "update Branch set Description = " + descentry.Text +
                        ", StreetAddress1 = " + addL1entry.Text + ", StreetAddress2 = " + addL2Entry.Text +
                        ", City = " + cityentry.Text + ", Province = " + proventry.Text + ", PostalCode = " + postalentry.Text +
                        ", Phone = " + phoneNumber + " where BranchID = " + BranchIdBx.Text;
                    myCommand.ExecuteNonQuery();
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }

                this.Close();
            }

            else if (RemoveRBtn.Checked == true) //deletes branch
            {
                try
                {
                    myCommand.CommandText = "delete from Branch where BranchId = " + BranchIdBx.Text;
                    myCommand.ExecuteNonQuery();
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }

                this.Close();
            }
        }

        private void AddRBtn_CheckedChanged(object sender, EventArgs e)
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

        private void EditRBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            resetRemoveEdit();
        }

        private void RemoveRBtn_CheckedChanged(object sender, EventArgs e)
        {
            resetRemoveEdit();
        }

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

                                if (phone.Length == 10)
                                    phoneentry.Text = "(" + phone[0] + phone[1] + phone[2] + ") " + phone[3] + phone[4] + phone[5] + "-" + phone[6] + phone[7] + phone[8] + phone[9];

                                else if (phone.Length == 11)
                                    phoneentry.Text = phone[0] + "(" + phone[1] + phone[2] + phone[3] + ") " + phone[4] + phone[5] + phone[6] + "-" + phone[7] + phone[8] + phone[9] + phone[10];

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
    }
}