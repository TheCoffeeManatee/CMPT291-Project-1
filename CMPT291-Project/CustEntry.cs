using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT291_Project
{
    public partial class CustEntry : Form
    {
        public CustEntry()
        {
            InitializeComponent();
        }

        private void custentrycancel_Click(object sender, EventArgs e)
        {
            this.CustEntryPanel.Controls.Clear();
            CustomersFrm CustomersFrm_Vrb = new CustomersFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            CustomersFrm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.CustEntryPanel.Controls.Add(CustomersFrm_Vrb);
            CustomersFrm_Vrb.Show();
        }
    }
}
