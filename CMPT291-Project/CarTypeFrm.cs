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
    public partial class CarTypeFrm : Form
    {
        public CarTypeFrm()
        {
            InitializeComponent();
        }

        private void QueryFrm_Load(object sender, EventArgs e)
        {

        }

        
        private void QueryLbl_Click(object sender, EventArgs e)
        {

        }

        private void CarTypeAdd_Click(object sender, EventArgs e)
        {
            this.CarTypePanel.Controls.Clear();
            CarTypeEntry CarTypeEntry_Vrb = new CarTypeEntry() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            CarTypeEntry_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.CarTypePanel.Controls.Add(CarTypeEntry_Vrb);
            CarTypeEntry_Vrb.Show();
        }
    }
}
