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
    public partial class TransNew : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public int carTypeId, pickbranchId, rtnBranchId;
        public string vin;
        public decimal diffBranchCost = 10;
        public decimal price = 0;

        public string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;


        public TransNew()
        {
            InitializeComponent();

            FullName.Visible = false;
            Add1.Visible = false;
            Add2.Visible = false;
            CP.Visible = false;
            Postal.Visible = false;
            Phone.Visible = false;
            Mbrship.Visible = false;

            SqlConnection myConnection = new SqlConnection(connectionString);

            //make connection
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

            fillCarType();
            fillBranch(0);
            fillBranch(1);
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
                            string phone = (string)myReader["Phone"];
                            int mem = (int)myReader["Membership"];

                            FullName.Visible = true;
                            Add1.Visible = true;
                            Add2.Visible = true;
                            CP.Visible = true;
                            Postal.Visible = true;
                            Phone.Visible = true;
                            Mbrship.Visible = true;

                            FullName.Text = fname.Trim() + ' ' + mname.Trim() + ' ' + lname.Trim();
                            Add1.Text = add1.Trim();
                            Add2.Text = add2.Trim();
                            CP.Text = city.Trim() + " " + prov.Trim();
                            Postal.Text = post.Trim();

                            if (phone.Length == 10)
                                Phone.Text = "(" + phone[0] + phone[1] + phone[2] + ") " + phone[3] + phone[4] + phone[5] + "-" + phone[6] + phone[7] + phone[8] + phone[9];

                            else if (phone.Length == 11)
                                Phone.Text = phone[0] + "(" + phone[1] + phone[2] + phone[3] + ") " + phone[4] + phone[5] + phone[6] + "-" + phone[7] + phone[8] + phone[9] + phone[10];

                            if (mem == 1)
                            {
                                Mbrship.Text = "Gold";
                                Mbrship.ForeColor = Color.Gold;
                            }

                            else
                                Mbrship.Text = "Standard";

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

                myReader.Close();

            }

            if (price != 0)
            {
                calcPriceBtn.Text = "Re-Calculate";
            }

        }

        private void FindCarsBtn_Click(object sender, EventArgs e)
        {
            checkCarType();

            //Only display cars of chosen carType that are availible for the entire date range
            try
            {
                myCommand.CommandText = "select * from Car where CarTypeId = " + carTypeId
                   + " and Car.VIN not in (select VIN from Rentals where ReturnDate between '"
                   + PickDate.Value.ToShortDateString() + "' and '" + RtnDate.Value.Date.ToShortDateString()
                   + "') and Car.VIN not in (select VIN from Rentals where PickupDate between '"
                   + PickDate.Value.ToShortDateString() + "' and '" + RtnDate.Value.Date.ToShortDateString() + "')";


                SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
                DataTable dt = new DataTable();
                myAdapter.Fill(dt);
                CarTable.DataSource = dt;

                if (dt.Rows.Count == 0)
                    MessageBox.Show("No cars available in this date range.", "Error");
            }

            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
            
        }

        private void carentrycancel_Click(object sender, EventArgs e)
        {
            this.NewTransPnl.Controls.Clear();
            TransNew NewTrans_Vrb = new TransNew() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            NewTrans_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.NewTransPnl.Controls.Add(NewTrans_Vrb);
            NewTrans_Vrb.Show();
        }

        private void carentrryaccept_Click(object sender, EventArgs e)
        {
            bool carTypeOkay = checkCarType();
            bool datesOkay = checkDates();
            bool branchesOkay = checkBranches();
            bool VINSuccess = updateVIN();
            bool custOkay = checkCust();

            if (VINSuccess && carTypeOkay && datesOkay && branchesOkay && custOkay)
            {
                DialogResult priceCheck = MessageBox.Show("Is the price up to date?", "Price Check", MessageBoxButtons.YesNo);

                if (priceCheck == DialogResult.Yes)
                {

                    try
                    {
                        myCommand.CommandText = "insert into Rentals values (" + pickbranchId + ",'" + PickDate.Value.ToShortDateString() + "',"
                            + rtnBranchId + ",'" + RtnDate.Value.Date.ToShortDateString() + "'," + carTypeId + "," + CustIdBx.Text + "," + vin + "," +
                            price + ")";
                        myCommand.ExecuteNonQuery();
                    }
                    catch (Exception e2)
                    {
                        MessageBox.Show(e2.ToString(), "Error");
                    }

                    updateMbr();

                    this.NewTransPnl.Controls.Clear();
                    TransNew NewTrans_Vrb = new TransNew() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    NewTrans_Vrb.FormBorderStyle = FormBorderStyle.None;
                    this.NewTransPnl.Controls.Add(NewTrans_Vrb);
                    NewTrans_Vrb.Show();
                }

                else if (priceCheck == DialogResult.No)
                    return;
            }

            else if (!VINSuccess || !carTypeOkay || !datesOkay || !custOkay || !branchesOkay)
            {
                MessageBox.Show("Please ensure all fields are filled correctly.", "Error");
            }
        }

        private void PickupBranchID_SelectedIndexChanged(object sender, EventArgs e)
        {
            getBranchId(0);

            if (price != 0)
            {
                calcPriceBtn.Text = "Re-Calculate";
            }
        }

        private void RtnBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            getBranchId(1);

            if (price != 0)
            {
                calcPriceBtn.Text = "Re-Calculate";
            }
        }

        //update branchIds based on choice in dropdowns; 0 for pickup, 1 for return
        void getBranchId(int branchType)
        {
            try
            {
                if (branchType == 0)
                    myCommand.CommandText = "select BranchId from Branch where Description = '" + PickupBranchID.Text + "'";

                else if (branchType == 1)
                    myCommand.CommandText = "select BranchId from Branch where Description = '" + RtnBranch.Text + "'";

                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    if (myReader.HasRows)
                    {
                        if (branchType == 0)
                            pickbranchId = (int)myReader["BranchId"];
                        else if (branchType == 1)
                            rtnBranchId = (int)myReader["BranchId"];
                    }
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

            if (price != 0)
            {
                calcPriceBtn.Text = "Re-Calculate";
            }
        }

        //fill cartype dropdown
        private void fillCarType()
        {
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
        }

        //fill Pickup Branch dropdowns; 0 for pickup, 1 for return
        private void fillBranch(int branchType)
        {
            
            myCommand.CommandText = "select Description from Branch";
            myReader = myCommand.ExecuteReader();

            if (myReader.HasRows)
            {
                while (myReader.Read())
                {
                    if (branchType == 0)
                        PickupBranchID.Items.Add(myReader[0]);
                    else if (branchType == 1)
                        RtnBranch.Items.Add(myReader[0]);
                }
            }

            else
                MessageBox.Show("Error Loading Branches", "Error");

            myReader.Close();
        }

        bool updateVIN()
        {
            if (CarTable.SelectedCells.Count == 1)
            {
                vin = (string)CarTable.SelectedCells[0].Value;
                return true;
            }

            return false;
        }

        //if >3 transactions, update selected customer to gold status
        void updateMbr()
        {
            try
            {
                myCommand.CommandText = "select count(*) as Count from Rentals where CustomerId = " + CustIdBx.Text;
                myReader = myCommand.ExecuteReader();
                myReader.Read();

                int count = (int)myReader["Count"];
                myReader.Close();

                if (count > 3)
                {
                    try
                    {
                        myCommand.CommandText = "update Customer Set Membership = 1 where CustomerId = " + CustIdBx.Text;
                        myCommand.ExecuteNonQuery();
                    }
                    catch (Exception e2)
                    {
                        MessageBox.Show(e2.ToString(), "Error");
                    }
                }

            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }


        }

        bool checkCarType()
        {
            if (CarTypePicker.Text.Length == 0)
                return false;
            else
                return true;
        }

        bool checkBranches()
        {

            if ((PickupBranchID.Text.Length == 0) || (RtnBranch.Text.Length == 0) || (RtnDate.Value.Date < PickDate.Value.Date))
                return false;

            else 
                return true;
        }

        bool checkDates()
        {
            if (RtnDate.Value.Date < PickDate.Value.Date)
                return false;
            else
                return true;
        }

        private void calcPriceBtn_Click(object sender, EventArgs e)
        {
            bool carTypeOkay = checkCarType();
            bool datesOkay = checkDates();
            bool branchesOkay = checkBranches();
            bool custOkay = checkCust();

            if (carTypeOkay && datesOkay && branchesOkay && custOkay)
            {
                calculatePrice((RtnDate.Value.Date - PickDate.Value.Date).Days);
                priceBx.Visible = true;
                priceBx.Text = price.ToString("N2");
                calcPriceBtn.Text = "Calculate";
            }

            else
            {
                MessageBox.Show("Please ensure all fields are filled correctly.", "Error");
            }

        }

        private void PickDate_ValueChanged(object sender, EventArgs e)
        {
            if (price != 0)
            {
                calcPriceBtn.Text = "Re-Calculate";
            }
        }

        private void RtnDate_ValueChanged(object sender, EventArgs e)
        {
            if (price != 0)
            {
                calcPriceBtn.Text = "Re-Calculate";
            }
        }

        bool checkCust()
        {
            int cust;
            int.TryParse(CustIdBx.Text, out cust);

            if (cust > 0)
                return true;
            else
                return false;
                
        }

        void calculatePrice(int totalDays)
        {
            decimal monthly = 0, weekly = 0, daily = 0;

            int months = totalDays/30;
            totalDays -= months;

            int weeks = (totalDays/7);
            totalDays -= weeks;

            int days = totalDays;

            try
            {
                myCommand.CommandText = "select * from CarType where CarTypeId = " + carTypeId;
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    if (myReader.HasRows)
                    {
                        daily = (decimal)myReader["DailyRate"];
                        weekly = (decimal)myReader["WeeklyRate"];
                        monthly = (decimal)myReader["MonthlyRate"];
                    }
                }
            }

            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }

            myReader.Close();

            price = (months * monthly) + (weeks * weekly) + (days * daily);

            //add diffBranchCost if membership is standard
            if ((PickupBranchID.Text != RtnBranch.Text) && (Mbrship.Text == "Standard"))
                price += diffBranchCost;

            return;
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
