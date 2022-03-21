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
    public partial class MainFrm : Form
    {  
        public MainFrm()
        {
            InitializeComponent();

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TransactionBtn_Click(object sender, EventArgs e)
        {
            this.HomePnl.Controls.Clear();
            TransactionsFrm TransactionsFrm_Vrb = new TransactionsFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            TransactionsFrm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.HomePnl.Controls.Add(TransactionsFrm_Vrb);
            TransactionsFrm_Vrb.Show();
        }

        private void BranchBtn_Click(object sender, EventArgs e)
        {
            this.HomePnl.Controls.Clear();
            BranchFrm BranchFrm_Vrb = new BranchFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            BranchFrm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.HomePnl.Controls.Add(BranchFrm_Vrb);
            BranchFrm_Vrb.Show();
        }

        private void CarsBtn_Click(object sender, EventArgs e)
        {
            this.HomePnl.Controls.Clear();
            CarsFrm CarsFrm_Vrb = new CarsFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            CarsFrm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.HomePnl.Controls.Add(CarsFrm_Vrb);
            CarsFrm_Vrb.Show();
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

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ResizeBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            { 
                this.WindowState = FormWindowState.Maximized;
                ResizeBtn.BackgroundImage = new Bitmap (CMPT291_Project.Properties.Resources.MIN);
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                ResizeBtn.BackgroundImage = new Bitmap (CMPT291_Project.Properties.Resources.MAX);
            }
        }


        private void CarTypeBtn_Click(object sender, EventArgs e)
        {
            this.HomePnl.Controls.Clear();
            CarTypeFrm CarTypeFrm_Vrb = new CarTypeFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            CarTypeFrm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.HomePnl.Controls.Add(CarTypeFrm_Vrb);
            CarTypeFrm_Vrb.Show();
        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            this.HomePnl.Controls.Clear();
            CustomersFrm CustomersFrm_Vrb = new CustomersFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            CustomersFrm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.HomePnl.Controls.Add(CustomersFrm_Vrb);
            CustomersFrm_Vrb.Show();
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            this.HomePnl.Controls.Clear();
            ReportsFrm ReportsFrm_Vrb = new ReportsFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ReportsFrm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.HomePnl.Controls.Add(ReportsFrm_Vrb);
            ReportsFrm_Vrb.Show();
        }

        private void HomePnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}