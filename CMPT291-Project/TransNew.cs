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
    public partial class TransNew : Form
    {
        public TransNew()
        {
            InitializeComponent();
        }

        private void AddCustBtn_Click(object sender, EventArgs e)
        {
            CustName.Visible = true;
            CustAdd1.Visible = true;
            CustAdd2.Visible = true;
            CustCity.Visible = true;
            Province.Visible = true;
            CustPhone.Visible = true;
            MemStatus.Visible = true;

        }

        private void FindCars_Click(object sender, EventArgs e)
        {
            PriceLbl.Visible = true;
        }
    }
}
