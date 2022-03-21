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
    public partial class TransactionsFrm : Form
    {
        public TransactionsFrm()
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

        private void HomeFrm_Load(object sender, EventArgs e)
        {

        }

        private void NewTransBtn_Click(object sender, EventArgs e)
        {
            this.TransPnl.Controls.Clear();
            TransNew TransNew_Vrb = new TransNew() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            TransNew_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.TransPnl.Controls.Add(TransNew_Vrb);
            TransNew_Vrb.Show();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            this.TransPnl.Controls.Clear();
            TransSearch TransSearch_Vrb = new TransSearch() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            TransSearch_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.TransPnl.Controls.Add(TransSearch_Vrb);
            TransSearch_Vrb.Show();
        }
    }
}
