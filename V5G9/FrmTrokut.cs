using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V5G9
{
    public partial class FrmTrokut : Form
    {
        public FrmTrokut()
        {
            InitializeComponent();
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            float a, b, gama;
            float.TryParse(txtA.Text, out a);
            float.TryParse(txtB.Text, out b);
            float.TryParse(txtGama.Text, out gama);

            if (radioButton3.Checked)
            {
                Raznostranican t = new Raznostranican();
                t.A = a;
                t.B = b;
                t.Gama = gama;

                t.IzracunajC();

                MessageBox.Show("Dužina stranice C = " + t.C.ToString(), "Rješenje");
            }
            else if (radioButton2.Checked)
            {
                Jednakokracan t = new Jednakokracan();
                t.A = a;
                t.B = a;
                t.Gama= gama;

                t.IzracunajC();
                MessageBox.Show("Dužina stranice C = " + t.C.ToString(), "Rješenje");

            }
            else if (radioButton1.Checked)
            {
                
                Jednakostranican t = new Jednakostranican();
                t.A = a;
                t.B = a;

                
                t.Gama = gama;
                if (t.Gama != 60)
                {
                    return;
                }

                t.IzracunajC();

                MessageBox.Show("Dužina stranice C = " + t.C.ToString(), "Rješenje");
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtB.ReadOnly = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtB.ReadOnly = true;
        }
    }
}
