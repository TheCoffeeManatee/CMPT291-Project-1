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
    public partial class BranchEntry : Form
    {
        public BranchEntry()
        {
            InitializeComponent();
        }

        private void CarEntryTitle_Click(object sender, EventArgs e)
        {

        }

        private void branchcancel_Click(object sender, EventArgs e)
        {
            this.BranchEPanel.Controls.Clear();
            BranchFrm BranchFrm_Vrb = new BranchFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            BranchFrm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.BranchEPanel.Controls.Add(BranchFrm_Vrb);
            BranchFrm_Vrb.Show();
        }
    }
}
