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
    public partial class CustomersFrm : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public int state = 0;

        public string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        //used to identify membership column to change ints to strings according to value
        //changes if the order of columns in customers changes
        public int mbrRow = 13;

        //used to identify membership column to change ints to strings according to value
        //changes if the order of columns in customers changes
        public int mbrRow = 13;

        public CustomersFrm()
        {
            InitializeComponent();
            myCommand = new SqlCommand("select * from Customer");
            state = 2;
            execute();
            state = 0;
        }
        private void execute()
        {
            myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            myCommand.Connection = myConnection;
            if (state == 1)
            {
                try
                {
                    myCommand.ExecuteNonQuery();
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }
            }
            else if (state == 2)
            {
                fillTable();
            }
            myConnection.Close();

        }

        private void fillTable()
        {
            myCommand.CommandType = CommandType.Text;
            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            DataTable dt = new DataTable();
            myAdapter.Fill(dt);

            dt.Columns["CustomerId"].ColumnName = "ID";
            dt.Columns["FirstName"].ColumnName = "First Name";
            dt.Columns["MiddleName"].ColumnName = "Middle Name";
            dt.Columns["LastName"].ColumnName = "Last Name";
            dt.Columns["StreetAddress1"].ColumnName = "Address Line 1";
            dt.Columns["StreetAddress2"].ColumnName = "Address Line 2";
            dt.Columns["PostalCode"].ColumnName = "Postal Code";
            dt.Columns["DrivingLicense"].ColumnName = "License Number";


            //change membership name depending on value from database involves cloning data
            DataTable dtCloned = dt.Clone();

            dtCloned.Columns[mbrRow].DataType = typeof(string);

            for (int i=0; i<dt.Rows.Count; i ++)

            {
                dtCloned.ImportRow(dt.Rows[i]);
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dtCloned.Rows[i][mbrRow].ToString() == "0")
                    dtCloned.Rows[i][mbrRow] = "Standard";
                else if (dtCloned.Rows[i][mbrRow].ToString() == "1")
                    dtCloned.Rows[i][mbrRow] = "Gold";
            }

            CustData.DataSource = dtCloned;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustEntry CustEntry_Vrb = new CustEntry() { TopLevel = true, TopMost = true };
            CustEntry_Vrb.FormBorderStyle = FormBorderStyle.None;
            CustEntry_Vrb.ShowDialog();
            myCommand.CommandText = CustEntry_Vrb.newCommand;
            state = CustEntry_Vrb.state;
            execute();
        }
    }
}
