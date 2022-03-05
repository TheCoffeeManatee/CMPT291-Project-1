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
    public partial class HomeFrm : Form
    {
        public HomeFrm()
        {
            InitializeComponent();
        }

        private void HomeFrm_Load(object sender, EventArgs e)
        {

        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            int Res = 0;
            if (AddBtn.Checked == true)
            {
                Res = Int32.Parse(FirstNum.Text) + Int32.Parse(SecondNum.Text);
            }

            if (SubBtn.Checked == true)
            {
                Res = Int32.Parse(FirstNum.Text) - Int32.Parse(SecondNum.Text);
            }

            if (MulBtn.Checked == true)
            {
                Res = Int32.Parse(FirstNum.Text) * Int32.Parse(SecondNum.Text);
            }

            Answer.Text = Res.ToString();
            Answer.Visible = true;
        }
    }
}
