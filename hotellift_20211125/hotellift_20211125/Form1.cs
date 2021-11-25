using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace hotellift_20211125
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnKilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnTorles_Click(object sender, EventArgs e)
        {
            lbx1.Items.Clear();
        }

        private void BtnFeltolt_Click(object sender, EventArgs e)
        {
            string[] feltolt = File.ReadAllLines("lift.txt");
            foreach (var item in feltolt)
            {
                lbx1.Items.Add(item);
            }

        }

        private void Btnbeir_Click(object sender, EventArgs e)
        {
            if (txtDatum.Text==""&& txtkartya.Text=="" && txtkezd.Text=="" &&  txtCel.Text=="")
            {
                MessageBox.Show("Nem írtál be adatot!");
            }
            else
            {
                string beir = txtDatum.Text + "" + txtCel.Text + "" + txtkartya.Text + "" + txtkezd.Text + "";
                lbx1.Items.Add(beir);
                MessageBox.Show("Sikeresen feltöltve.","Információ");
                
            }
        }

        private void BtnKiír_Click(object sender, EventArgs e)
        {
            
            foreach (var item in lbx1.Items)
            {
                File.AppendAllText("valami.txt", item + "\n");
            }
        }

        private void BtnKeres_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            foreach (var item in lbx1.Items)
            {
                lista.Add(item.ToString());
                
            }
            lbx1.Items.Clear();
            foreach (var item in lista)
            {
                if (item.Contains(txtDatum.Text))
                {
                    lbx1.Items.Add(item);
                }

            }
        }
    }
}
