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
    public partial class TransactionsFrm : Form
    {
        public TransactionsFrm()
        {
            InitializeComponent();
        }

        private void HomeFrm_Load(object sender, EventArgs e)
        {

        }

        private void NewTransBtn_Click(object sender, EventArgs e)
        {
            this.TransPnl.Controls.Clear();
            TransNew TransNew_Vrb = new TransNew() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            TransNew_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.TransPnl.Controls.Add(TransNew_Vrb);
            TransNew_Vrb.Show();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            this.TransPnl.Controls.Clear();
            TransSearch TransSearch_Vrb = new TransSearch() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            TransSearch_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.TransPnl.Controls.Add(TransSearch_Vrb);
            TransSearch_Vrb.Show();
        }
    }
}
