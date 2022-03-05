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

namespace Lab6_Modern
{
    public partial class Form1 : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;


        public Form1()
        {
            InitializeComponent();
            ///////////////////////////////
            //operation.Items.Clear();
            //operation.Items.Add("Show all");
            //operation.Items.Add("Show with starting grade: ");
            //////////////////////////////////
            ///
            String connectionString = "Server = DESKTOP-L3H29R4; Database = ConnectTutorial; Trusted_Connection = yes;";


            /* Starting the connection */
            /*  SqlConnection myConnection = new SqlConnection("user id=temp2;" + // Username
                                         "password=adminadmin;" + // Password
                                         "server=localhost;" + // IP for the server
                                                               //"Trusted_Connection=yes;" +
                                         "database=ConnectTutorial; " + // Database to connect to
                                         "connection timeout=30"); // Timeout in seconds */

            SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds

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

            this.HomePnl.Controls.Clear();
            TransactionsFrm HomeFrm_Vrb = new TransactionsFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            HomeFrm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.HomePnl.Controls.Add(HomeFrm_Vrb);
            HomeFrm_Vrb.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.HomePnl.Controls.Clear();
            TransactionsFrm HomeFrm_Vrb = new TransactionsFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            HomeFrm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.HomePnl.Controls.Add(HomeFrm_Vrb);
            HomeFrm_Vrb.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.HomePnl.Controls.Clear();
            BranchFrm InsertFrm_Vrb = new BranchFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            InsertFrm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.HomePnl.Controls.Add(InsertFrm_Vrb);
            InsertFrm_Vrb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.HomePnl.Controls.Clear();
            CarsFrm DeleteFrm_Vrb = new CarsFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            DeleteFrm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.HomePnl.Controls.Add(DeleteFrm_Vrb);
            DeleteFrm_Vrb.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MenuBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ResizeBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            { 
                this.WindowState = FormWindowState.Maximized;
                ResizeBtn.BackgroundImage = new Bitmap (@"C:\Users\tpete\source\repos\Lab6_Modern\Lab6_Modern\Properties\MIN.png");
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                ResizeBtn.BackgroundImage = new Bitmap (@"C:\Users\tpete\source\repos\Lab6_Modern\Lab6_Modern\Properties\MAX.png");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void CalcLabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(10, 100, 100, 100);
            e.Graphics.DrawString("Needs fixing", this.Font, Brushes.LightGray, rect);
        }

        private void QueryBtn_Click(object sender, EventArgs e)
        {
            this.HomePnl.Controls.Clear();
            CarTypeFrm QueryFrm_Vrb = new CarTypeFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            QueryFrm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.HomePnl.Controls.Add(QueryFrm_Vrb);
            QueryFrm_Vrb.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.HomePnl.Controls.Clear();
            CustomersFrm Customers_Vrb = new CustomersFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Customers_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.HomePnl.Controls.Add(Customers_Vrb);
            Customers_Vrb.Show();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            this.HomePnl.Controls.Clear();
            ReportsFrm ReportsFrm_Vrb = new ReportsFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ReportsFrm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.HomePnl.Controls.Add(ReportsFrm_Vrb);
            ReportsFrm_Vrb.Show();
        }
    }
}