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
    public partial class ReportsFrm : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myDataReader;
        public ReportsFrm()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; //connect to databas

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

        private void ReportUpdate1_Click(object sender, EventArgs e) // Report number 1
        {
            string d1 = DatePick1.Value.ToString("yyyy-MM-dd"); // get both dates
            string d2 = DatePick2.Value.ToString("yyyy-MM-dd");
            if (DatePick1.Value.Date <= DatePick2.Value.Date) // checks to see if the first date is before the second date
            {

                myCommand.CommandText = "select distinct Car.VIN, CarType.Description, CarType.DailyRate, CarType.WeeklyRate, CarType.MonthlyRate, totalAmount "
                    + "from Car, CarType, Rentals, (select Rentals.VIN, sum(Rentals.Price) as totalAmount from Rentals where CAST(Rentals.ReturnDate as DATE) <= '" + d2
                    + "' and CAST(Rentals.PickupDate as DATE) >= '" + d1 + "' group by Rentals.VIN) as sumTotal "
                    + "where sumTotal.VIN = Car.VIN and Car.VIN = Rentals.VIN and Rentals.CarTypeId = CarType.CarTypeId and sumTotal.totalAmount >= 500"; //query that will find cars that have collect $500 or more through the selected dates
                dataGridView1.Rows.Clear();
                try
                {
                    MessageBox.Show(myCommand.CommandText);
                    myDataReader = myCommand.ExecuteReader();
                    while (myDataReader.Read())
                    {
                        dataGridView1.Rows.Add(myDataReader["VIN"].ToString(), myDataReader["Description"].ToString(),
                            myDataReader["DailyRate"].ToString(), myDataReader["WeeklyRate"].ToString(), myDataReader["MonthlyRate"].ToString(),
                            myDataReader["totalAmount"].ToString()); // add to grid
                    }
                    myDataReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }
            else
            {
                MessageBox.Show("Error: Please select the left date to be before the right date.");
            }
        }

        private void UpdateReport2_Click(object sender, EventArgs e) //Report number 2
        {
            string yearPicked2 = this.YearBox2.Text; // selected year
            string StartOfYear = yearPicked2 + "-01-01"; // start of the year       
            string EndOfYear = yearPicked2 + "-12-31"; // end of the year
            if (this.YearBox2.Text != "") // checks to make sure the user has selected a date
            {
                myCommand.CommandText = "select Branch.BranchId, Branch.Description, AmountOfRents, AmountOfMoney from Branch," +
                    " (Select Rentals.PickupBranch, count(Rentals.PickupBranch) as AmountOfRents from Rentals where CAST(Rentals.PickupDate as DATE) >='" + StartOfYear + "' and CAST(Rentals.PickupDate as DATE) <= '" + EndOfYear + "' group by Rentals.PickupBranch) as TotalRents," +
                    " (select Rentals.PickupBranch, sum(Rentals.Price) as AmountOfMoney from Rentals where CAST(Rentals.PickupDate as DATE) >='" + StartOfYear + "' and CAST(Rentals.PickupDate as DATE) <= '" + EndOfYear + "' group by Rentals.PickupBranch) as TotalAmount " +
                    " where Branch.BranchId = TotalRents.PickupBranch and Branch.BranchId = TotalAmount.PickupBranch"; // will find Branch ID, Branch Name, total amount of rents and money made within a given year.
                dataGridView2.Rows.Clear();
                try
                {
                    MessageBox.Show(myCommand.CommandText);
                    myDataReader = myCommand.ExecuteReader();
                    dataGridView2.Rows.Clear();
                    while (myDataReader.Read())
                    {
                        dataGridView2.Rows.Add(myDataReader["BranchId"].ToString(), myDataReader["Description"].ToString(),
                            myDataReader["AmountOfRents"].ToString(), myDataReader["AmountOfMoney"].ToString()); //add to grid
                    }
                    myDataReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }
            else
            {
                MessageBox.Show("Error: Please select a year to view the report.");
            }
        }

        private void UpdateButton4_Click(object sender, EventArgs e) //Report Number 4
        {
            myCommand.CommandText = "select Customer.CustomerId, Customer.FirstName, Customer.MiddleName, Customer.LastName, numberOfRentals " +
                "from Customer, (select CustomerId, count(CustomerId) as numberOfRentals from Rentals group by CustomerId) as customerRental " +
                "where Customer.CustomerId = customerRental.CustomerId and numberOfRentals >= 3"; //query that will find customers that have rented more than 3 cars total
            dataGridView4.Rows.Clear();
            try
            {
                MessageBox.Show(myCommand.CommandText);
                myDataReader = myCommand.ExecuteReader();
                dataGridView4.Rows.Clear();
                while (myDataReader.Read())
                {
                    dataGridView4.Rows.Add(myDataReader["CustomerId"].ToString(), myDataReader["FirstName"].ToString(), 
                        myDataReader["MiddleName"].ToString(), myDataReader["LastName"].ToString(), myDataReader["NumberOfRentals"].ToString()); //add to grid
                }
                myDataReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }

        }

        private void UpdateButton3_Click(object sender, EventArgs e) //Report number 3
        {
            string monthPicked = this.MonthBox3.Text;
            string yearPicked = this.YearBox1.Text;
            string d5;
            string d6;
            if (this.MonthBox3.Text != "" && this.YearBox1.Text != "")
            {
                switch (monthPicked) //Create the two dates to show one month
                {
                    case "January":
                        d5 = yearPicked + "-01-01";
                        d6 = yearPicked + "-01-31";
                        break;
                    case "February":
                        d5 = yearPicked + "-02-01";
                        d6 = yearPicked + "-02-28";
                        break;
                    case "March":
                        d5 = yearPicked + "-03-01";
                        d6 = yearPicked + "-03-31";
                        break;
                    case "April":
                        d5 = yearPicked + "-04-01";
                        d6 = yearPicked + "-04-30";
                        break;
                    case "May":
                        d5 = yearPicked + "-05-01";
                        d6 = yearPicked + "-05-31";
                        break;
                    case "June":
                        d5 = yearPicked + "-06-01";
                        d6 = yearPicked + "-06-30";
                        break;
                    case "July":
                        d5 = yearPicked + "-07-01";
                        d6 = yearPicked + "-07-31";
                        break;
                    case "August":
                        d5 = yearPicked + "-08-01";
                        d6 = yearPicked + "-08-31";
                        break;
                    case "September":
                        d5 = yearPicked + "-09-01";
                        d6 = yearPicked + "-09-30";
                        break;
                    case "October":
                        d5 = yearPicked + "-10-01";
                        d6 = yearPicked + "-10-31";
                        break;
                    case "November":
                        d5 = yearPicked + "-11-01";
                        d6 = yearPicked + "-11-30";
                        break;
                    case "December":
                        d5 = yearPicked + "-12-01";
                        d6 = yearPicked + "-12-31";
                        break;
                    default: //if no month was selected
                        d5 = "0000-00-00";
                        d6 = "0000-00-00";
                        break;

                }
                myCommand.CommandText = "select distinct Branch.BranchId, Branch.Description from Branch, ((select Branch.BranchId from Branch) except " +
                   "(select distinct Rentals.PickupBranch from Rentals where CAST(Rentals.PickupDate as DATE) >= '" + d5 +
                   "' and CAST(Rentals.PickupDate as DATE) <= '" + d6 + "')) as NoRents where Branch.BranchId = NoRents.BranchId"; // will find branch ID, and branch name given that they did not preform any rents given a year and a month.
                dataGridView3.Rows.Clear();
                try
                {
                    MessageBox.Show(myCommand.CommandText);
                    myDataReader = myCommand.ExecuteReader();
                    dataGridView3.Rows.Clear();
                    while (myDataReader.Read())
                    {
                        dataGridView3.Rows.Add(myDataReader["BranchId"].ToString(), myDataReader["Description"].ToString()); //add to grid
                    }
                    myDataReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                    myDataReader.Close();
                }
            }
            else
            {
                if(this.YearBox1.Text == "" && this.MonthBox3.Text == "")
                {
                    MessageBox.Show("Error: Please select a year and a month.");
                }
                else if(this.YearBox1.Text != "" && this.MonthBox3.Text == "")
                {
                    MessageBox.Show("Error: Please select a month.");
                }
                else if(this.YearBox1.Text == "" && this.MonthBox3.Text != "")
                {
                    MessageBox.Show("Error: Please select a year.");
                }
            }
        }

        private void UpdateReport5_Click(object sender, EventArgs e) //report 5
        {
            myCommand.CommandText = "select distinct Car.VIN, Car.Model, CarType.Description, Car.Odometer, TotalMoneyMade " +
                "from Car, CarType, Rentals, (select Rentals.VIN, sum(Rentals.Price) as TotalMoneyMade from Rentals group by Rentals.VIN) as YTDCar " +
                "where Car.VIN = Rentals.VIN and Car.VIN = YTDCar.VIN and Rentals.CarTypeId = CarType.CarTypeId"; // this will find Vin, car model, car type, odometer, and total money made all time from a car
            dataGridView5.Rows.Clear();
            try
            {
                MessageBox.Show(myCommand.CommandText);
                myDataReader = myCommand.ExecuteReader();
                dataGridView5.Rows.Clear();
                while (myDataReader.Read())
                {
                    dataGridView5.Rows.Add(myDataReader["VIN"].ToString(), myDataReader["Model"].ToString(), myDataReader["Description"].ToString()
                        , myDataReader["Odometer"].ToString(), myDataReader["TotalMoneyMade"].ToString()); //add to grid
                }
                myDataReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
                myDataReader.Close();
            }
        }

        private void Info1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Report 1: This report will show the VIN, Car Type, Daily Rate, Weekly RateMonthlyRate, and Total Amount given two dates. Total amount is how much money that one car made in the given time. This will only show if the car has made more than or equal to 500 dollars in that given time frame.");
        }

        private void Info2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Report 2: Given a selected year this report will show the Branch ID, Branch Name, Amount of Rents made in that Year, and the total amount of money made in that year");
        }

        private void info3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Report 3: Given a Month and a year, this report will show all Branch ID, Branch Name that made no rents in that given time frame.");
        }

        private void info4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Report 4: This report will show Customer ID, Customer First Middle and Last name, and the total amount of rentals made by that one customer. This will Only show Customers who have made more than 3 rents total");
        }

        private void info5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Report 5: This report will show VIN, Car Model, Car Type, Odometer, and the total amount of money made all tine my this one car.");
        }
    }
}
