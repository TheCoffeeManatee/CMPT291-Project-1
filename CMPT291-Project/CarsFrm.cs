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
    public partial class CarsFrm : Form
    {
        public CarsFrm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.CarsPanel.Controls.Clear();
            CarEntry CarEntry_Vrb = new CarEntry() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            CarEntry_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.CarsPanel.Controls.Add(CarEntry_Vrb);
            CarEntry_Vrb.Show();
        }
    }
}
