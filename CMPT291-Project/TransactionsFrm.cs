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
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public int state = 0;

        public string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public TransactionsFrm()
        {
            InitializeComponent();
            myCommand = new SqlCommand("select * from Rentals");
            state = 1;
            execute();
            state = 0;
        }

        private void HomeFrm_Load(object sender, EventArgs e)
        {

        }

        private void AddTransBtn_Click(object sender, EventArgs e)
        {
            this.TransPnl.Controls.Clear();
            TransNew TransNew_Vrb = new TransNew() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            TransNew_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.TransPnl.Controls.Add(TransNew_Vrb);
            TransNew_Vrb.Show();
            TransactionsFrmLbl.Visible = false;
            AddTransBtn.Visible = false;
            SearchBtn.Visible = false;
        }

        private void SearchBtn_Click_1(object sender, EventArgs e)
        {
            TransSearch TransSearch_Vrb = new TransSearch() {TopLevel = true, TopMost = true };
            TransSearch_Vrb.FormBorderStyle = FormBorderStyle.None;
            TransSearch_Vrb.ShowDialog();
            myCommand.CommandText = TransSearch_Vrb.newCommand;
            state = TransSearch_Vrb.state;
            execute();
        }

        private void execute()
        {
            if (state == 1)
            {
                myConnection = new SqlConnection(connectionString);
                myConnection.Open();
                myCommand.Connection = myConnection;
                fillTable();
                myConnection.Close();
            }
        }
        private void fillTable()
        {
            myCommand.CommandType = CommandType.Text;
            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            DataTable dt = new DataTable();
            myAdapter.Fill(dt);
            TransData.DataSource = dt;
        }
    }
}
