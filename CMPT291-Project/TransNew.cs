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
        public int goldFlag = 0, upgradeCTId = 0; //used to mark if requested carType was not availible for free upgrade on gold members
        public string vin, pBranchDes, rBranchDes, carTypeDes;
        public decimal diffBranchCost = 10;
        public decimal price = 0;
        public DateTime oldReturn;

        public string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public TransNew()
        {
            InitializeComponent();
            AddRBtn.Checked = true;

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
                calcPriceBtn.Show();
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

                //rename columns
                dt.Columns["CarTypeId"].ColumnName = "Type ID";
                dt.Columns["BranchId"].ColumnName = "Branch ID";

                CarTable.DataSource = dt;

                if (CarTable.Rows.Count == 0)
                {
                    if (Mbrship.Text == "Gold") //current carTypeId is saved to be used in calculating price
                    {
                        goldFlag = 1;
                        MessageBox.Show("No cars available in this date range.\n\nFree upgrade applied", "Error");
                    }

                    else
                        MessageBox.Show("No cars available in this date range.", "Error");

                }
            }

            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
            
        }

        private void carentrycancel_Click(object sender, EventArgs e)
        {
            this.NewTransPnl.Controls.Clear();
            TransactionsFrm TransactionsFrm_Vrb = new TransactionsFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            TransactionsFrm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.NewTransPnl.Controls.Add(TransactionsFrm_Vrb);
            TransactionsFrm_Vrb.Show();
        }

        private void carentrryaccept_Click(object sender, EventArgs e)
        {
            bool carTypeOkay = checkCarType();
            bool datesOkay = checkDates();
            bool branchesOkay = checkBranches();
            bool custOkay = checkCust();

            if (AddRBtn.Checked)
            {
                if (carTypeOkay && datesOkay && branchesOkay && custOkay)
                {
                    DialogResult priceCheck = MessageBox.Show("Is the price up to date?", "Price Check", MessageBoxButtons.YesNo);

                    if (priceCheck == DialogResult.Yes)
                    {

                        try
                        {
                            myCommand.CommandText = "insert into Rentals values (" + pickbranchId + ",'" + PickDate.Value.ToShortDateString() + "',"
                                + rtnBranchId + ",'" + RtnDate.Value.Date.ToShortDateString() + "'," + carTypeId + "," + CustIdBx.Text + ",'" + vin + "'," +
                                price + ", 0)";
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
            }

            else if (EditRBtn.Checked || completeRBtn.Checked)
            {
                int late = 0;

                if (completeRBtn.Checked)
                {
                    if (LateCheck.Checked)
                            late = 1; 
                }

                if (carTypeOkay && datesOkay && branchesOkay && custOkay)
                {
                    DialogResult priceCheck = MessageBox.Show("Is the price up to date?", "Price Check", MessageBoxButtons.YesNo);

                    if (priceCheck == DialogResult.Yes)
                    {

                        try
                        {   //update rental
                            myCommand.CommandText = "update Rentals set PickupBranch = " + pickbranchId + ", PickupDate = '"
                                + PickDate.Value.ToShortDateString() + "', ReturnBranch = " + rtnBranchId + ", ReturnDate = '"
                                + RtnDate.Value.Date.ToShortDateString() + "', CarTypeID = " + carTypeId + ", CustomerId = " 
                                + CustIdBx.Text + ", VIN = '" + vin + "', Price = " + price + ", Late = " + late + "where RentalId = " + TransIdBx.Text;
                            myCommand.ExecuteNonQuery();

                            //update branch of car
                            myCommand.CommandText = "update Car set BranchId = " + rtnBranchId + " where VIN = '" + vin + "'";
                            myCommand.ExecuteNonQuery();

                        }
                        catch (Exception e2)
                        {
                            MessageBox.Show(e2.ToString(), "Error");
                        }

                        this.NewTransPnl.Controls.Clear();
                        TransNew NewTrans_Vrb = new TransNew() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                        NewTrans_Vrb.FormBorderStyle = FormBorderStyle.None;
                        this.NewTransPnl.Controls.Add(NewTrans_Vrb);
                        NewTrans_Vrb.Show();
                    }

                    else if (priceCheck == DialogResult.No)
                        return;
                }
            }

            else if (RemoveRBtn.Checked)
            {
                DialogResult removeCheck = MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo);


                if (removeCheck == DialogResult.Yes)
                {

                    try
                    {
                        myCommand.CommandText = "delete from Rentals where RentalID = " + TransIdBx.Text;
                        myCommand.ExecuteNonQuery();
                    }
                    catch (Exception e2)
                    {
                        MessageBox.Show(e2.ToString(), "Error");
                    }

                    this.NewTransPnl.Controls.Clear();
                    TransNew NewTrans_Vrb = new TransNew() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    NewTrans_Vrb.FormBorderStyle = FormBorderStyle.None;
                    this.NewTransPnl.Controls.Add(NewTrans_Vrb);
                    NewTrans_Vrb.Show();
                }

                else if (removeCheck == DialogResult.No)
                    return;
            }

            return;
        }

        private void PickupBranchID_SelectedIndexChanged(object sender, EventArgs e)
        {
            getBranchId(0);

            if (price != 0)
            {
                calcPriceBtn.Text = "Re-Calculate";
                calcPriceBtn.Show();
            }
        }

        private void RtnBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            getBranchId(1);

            if (price != 0)
            {
                calcPriceBtn.Text = "Re-Calculate";
                calcPriceBtn.Show();
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

        void getBranchDes(int branchType)
        {
            try
            {
                if (branchType == 0)
                    myCommand.CommandText = "select Description from Branch where BranchId = " + pickbranchId;

                else if (branchType == 1)
                    myCommand.CommandText = "select Description from Branch where BranchId = " + rtnBranchId;

                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    if (myReader.HasRows)
                    {
                        if (branchType == 0)
                            pBranchDes = (string)myReader["Description"];
                        else if (branchType == 1)
                            rBranchDes = (string)myReader["Description"];
                    }
                }
            }

            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }

            myReader.Close();
        }

        void getCarTypeDes()
        {
            try
            {
                myCommand.CommandText = "select Description from CarType where CarTypeId = " + carTypeId;
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    if (myReader.HasRows)
                        carTypeDes = (string)myReader["Description"];
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
                myCommand.CommandText = "select CarTypeId, Level from CarType where Description = '" + CarTypePicker.Text + "'";
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    if (myReader.HasRows)
                    {
                        if (goldFlag == 0) //ensure upgradeCarID stays the same as carTypeID until flag is thrown
                        {
                            carTypeId = (int)myReader["CarTypeId"];
                            upgradeCTId = carTypeId;
                        }

                        else
                            carTypeId = (int)myReader["CarTypeId"];

                        int lvl = (int)myReader["Level"];
                        level.Text = lvl.ToString();
                    }
                }
                myReader.Close();
            }

            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
            myReader.Close();

            if (price != 0) //price has been previously calculated
            {
                calcPriceBtn.Text = "Re-Calculate";
                calcPriceBtn.Show();
            }
            myReader.Close();
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
            {
                MessageBox.Show("Invalid CarType", "Error");
                return false;
            }
            else
                return true;
        }

        bool checkBranches()
        {

            if ((PickupBranchID.Text.Length == 0) || (RtnBranch.Text.Length == 0))
            {
                MessageBox.Show("Invalid Branch", "Error");
                return false;
            }

            else
                return true;
        }

        bool checkDates()
        {
            if (RtnDate.Value.Date < PickDate.Value.Date)
            {
                MessageBox.Show("Invalid Pickup Date", "Error");
                return false;
            }
            else
                return true;
        }

        private void calcPriceBtn_Click(object sender, EventArgs e)
        {
            int totalDays;
            bool carTypeOkay = checkCarType();
            bool datesOkay = checkDates();
            bool branchesOkay = checkBranches();
            bool custOkay = checkCust();

            if (PickDate.Value.Date == RtnDate.Value.Date)
            {
                totalDays = 1;
            }

            else
                totalDays = (RtnDate.Value.Date - PickDate.Value.Date).Days;

            if (carTypeOkay && datesOkay && branchesOkay && custOkay)
            {
                calculatePrice(totalDays);
                priceBx.Visible = true;
                priceBx.Text = price.ToString("N2");
                calcPriceBtn.Text = "Calculate";
                calcPriceBtn.Hide();
            }
        }

        private void PickDate_ValueChanged(object sender, EventArgs e)
        {
            if (price != 0)
            {
                calcPriceBtn.Text = "Re-Calculate";
                calcPriceBtn.Show();
            }
        }

        private void AddRBtn_CheckedChanged(object sender, EventArgs e)
        {
            LateCheck.Visible = false;
            FindTransBtn.Visible = false;
            TransIdBx.Visible = false;
        }
            
        private void EditRBtn_CheckedChanged(object sender, EventArgs e)
        {
            LateCheck.Visible = false;

            FindTransBtn.Visible = true;
            TransIdBx.Visible = true;
        }


        private void RemoveRBtn_CheckedChanged(object sender, EventArgs e)
        {
            LateCheck.Visible = false;

            FindTransBtn.Visible = true;
            TransIdBx.Visible = true;
        }

        private void completeRBtn_CheckedChanged(object sender, EventArgs e)
        {
            LateCheck.Visible = true;
            FindTransBtn.Visible = true;
            TransIdBx.Visible = true;
        }

        private void LateCheck_CheckedChanged(object sender, EventArgs e)
        {
            oldReturn = RtnDate.Value;
            MessageBox.Show("Update return date and re-calculate price", "Reminder");
        }

        private void FindTransBtn_Click(object sender, EventArgs e)
        {
            //converts string to integer 
            int displayID;
            bool success = int.TryParse(TransIdBx.Text, out displayID);

            if (success)
            {
                try
                {
                    myCommand.CommandText = "select * from Rentals where RentalId  = " + displayID;
                    myReader = myCommand.ExecuteReader();

                    if (myReader.HasRows)
                    {
                        //saves variables read and displays them in the appropriate fields
                        while (myReader.Read())
                        {
                            pickbranchId = (int)myReader["PickupBranch"];
                            DateTime pB = (DateTime)myReader["PickupDate"];
                            rtnBranchId = (int)myReader["ReturnBranch"];
                            DateTime rB = (DateTime)myReader["ReturnDate"];
                            vin = (string)myReader["VIN"];
                            carTypeId = (int)myReader["CarTypeId"];
                            int custID = (int)myReader["CustomerID"];
                            price = (decimal)myReader["Price"];
                            int lt = 0;

                            if (!myReader.IsDBNull("Late"))
                                lt = (int)myReader["Late"];

                            PickDate.Value = pB;
                            RtnDate.Value = rB;
                            CustIdBx.Text = custID.ToString();
                            priceBx.Text = price.ToString("N2");

                            priceBx.Visible = true;
                        }

                        myReader.Close();

                        FindID.PerformClick();

                        //change comboboxes to the correct descriptions
                        getBranchDes(0);
                        PickupBranchID.SelectedIndex = PickupBranchID.FindString(pBranchDes);

                        getBranchDes(1);
                        RtnBranch.SelectedIndex = RtnBranch.FindString(rBranchDes);

                        getCarTypeDes();
                        CarTypePicker.SelectedIndex = CarTypePicker.FindString(carTypeDes);


                        try
                        {

                            myCommand.CommandText = "select Make, Model, Year from Car where VIN = '" + vin + "'";
                            myReader = myCommand.ExecuteReader();

                            while (myReader.Read())
                            {
                                if (myReader.HasRows)
                                {
                                    string mk = (string)myReader["Make"];
                                    string md = (string)myReader["Model"];
                                    int yr = (int)myReader["Year"];

                                    selCarInfo.Text = yr.ToString() + " " + mk + " " + md + " VIN: " + vin;
                                }
                            }
                            myReader.Close();
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

                myReader.Close();

            }

            if (price != 0)
            {
                calcPriceBtn.Text = "Re-Calculate";
                calcPriceBtn.Show();
            }
        }

        private void RtnDate_ValueChanged(object sender, EventArgs e)
        {
            if (price != 0)
            {
                calcPriceBtn.Text = "Re-Calculate";
                calcPriceBtn.Show();
            }
        }

        bool checkCust()
        {
            int cust;
            int.TryParse(CustIdBx.Text, out cust);

            if (cust > 0)
                return true;

            MessageBox.Show("Invalid Customer", "Error");
            return false;
                
        }

        void calculatePrice(int totalDays)
        {
            decimal monthly = 0, weekly = 0, daily = 0;

            if (LateCheck.Checked)
            {
                int overDueDays = (RtnDate.Value.Date - oldReturn.Date).Days;

                try
                {
                    myCommand.CommandText = "select * from CarType where CarTypeId = " + upgradeCTId;
                    myReader = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        if (myReader.HasRows)
                            daily = (decimal)myReader["DailyRate"];
                    }
                    myReader.Close();
                }

                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }


                price += (daily * overDueDays);
                myReader.Close();

                return;

            }

            int months = totalDays/30;
            totalDays -= months*30;

            int weeks = (totalDays/7);
            totalDays -= weeks*7;

            int days = totalDays;

            try
            {
                if (goldFlag == 0)
                    myCommand.CommandText = "select * from CarType where CarTypeId = " + carTypeId;

                else if (goldFlag == 1)
                {
                    myCommand.CommandText = "select * from CarType where CarTypeId = " + upgradeCTId;
                }
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

        private void CarTable_SelectionChanged(object sender, EventArgs e)
        {
            if (CarTable.SelectedCells.Count == 1)
            {
                try
                {
                    vin = (string)CarTable.SelectedCells[0].Value;
                }

                catch
                {
                    MessageBox.Show("Please select a VIN from the list of cars", "Error");
                }

                try
                {
                    
                    myCommand.CommandText = "select Make, Model, Year from Car where VIN = '" + vin + "'";
                    myReader = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        if (myReader.HasRows)
                        {
                            string mk = (string)myReader["Make"];
                            string md = (string)myReader["Model"];
                            int yr = (int)myReader["Year"];

                            selCarInfo.Text = yr.ToString() + " " + mk + " " + md + " VIN: " + vin;
                        }
                    }
                }


                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }
            }
            myReader.Close();
        }

    }
}
