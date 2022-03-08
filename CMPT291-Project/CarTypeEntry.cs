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
    public partial class CarTypeEntry : Form
    {
        public CarTypeEntry()
        {
            InitializeComponent();
        }

        private void ctentrycancel_Click(object sender, EventArgs e)
        {
            this.CTEntryPanel.Controls.Clear();
            CarTypeFrm CarTypeFrm_Vrb = new CarTypeFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            CarTypeFrm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.CTEntryPanel.Controls.Add(CarTypeFrm_Vrb);
            CarTypeFrm_Vrb.Show();
        }
    }
}
