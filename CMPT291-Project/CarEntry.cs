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
    public partial class CarEntry : Form
    {
        public CarEntry()
        {
            InitializeComponent();
        }

        private void CarEntryTitle_Click(object sender, EventArgs e)
        {

        }


        private void carentrycancel_Click_1(object sender, EventArgs e)
        {
            this.CarEntryPanel.Controls.Clear();
            CarsFrm CarsFrm_Vrb = new CarsFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            CarsFrm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.CarEntryPanel.Controls.Add(CarsFrm_Vrb);
            CarsFrm_Vrb.Show();
        }
    }
}
