using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210929
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnKilepes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnevszak_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtbox.Text);
            if (a<3 ||a==12)
            {
                lblevszak.Text = "Tél";
            }
            else if (a<6)
            {
                lblevszak.Text = "Tavasz";
            }
            else if (a<9)
            {
                lblevszak.Text = "Nyár";
            }
            else
            {
                lblevszak.Text = "Ősz";
            }
        }
    }
}
