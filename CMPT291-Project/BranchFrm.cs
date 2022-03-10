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

namespace CMPT291_Project
{
    
    public partial class BranchFrm : Form
    {

        public BranchFrm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HomeFormPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomersLbl_Click(object sender, EventArgs e)
        {
            
        }

        private void BranchAdd_Click(object sender, EventArgs e)
        {
            this.BranchPanel.Controls.Clear();
            BranchEntry BranchEntry_Vrb = new BranchEntry() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            BranchEntry_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.BranchPanel.Controls.Add(BranchEntry_Vrb);
            BranchEntry_Vrb.Show();
        }
    }
}
