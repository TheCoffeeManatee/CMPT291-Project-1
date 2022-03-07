using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Modern
{
    public partial class CustomersFrm : Form
    {
        public CustomersFrm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            this.CustomerPanel.Controls.Clear();
            CustEntry CustEntry_Vrb = new CustEntry() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            CustEntry_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.CustomerPanel.Controls.Add(CustEntry_Vrb);
            CustEntry_Vrb.Show();
        }
    }
}
