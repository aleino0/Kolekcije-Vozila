using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolekcije_ui
{
    public partial class Form1 : Form
    {
        List<Vozilo> VoziloList = new List<Vozilo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void unos_Click(object sender, EventArgs e)
        {
            try
            {
                if (marka.Text == "" ||
                    model.Text == "" ||
                    vrsta.Text == "")
                {
                    MessageBox.Show("pogrešan unos. Molimo pokušajte ponovo", "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    marka.Clear();
                    model.Clear();
                }
                else 
                {
                    Vozilo vozilo = new Vozilo(marka.Text, model.Text, vrsta.Text);
                    VoziloList.Add(vozilo);
                    marka.Clear();
                    model.Clear();
                    marka.Focus();
                }
            }
            catch
            {
                MessageBox.Show("pogrešan unos. Molimo pokušajte ponovo", "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                marka.Clear();
                model.Clear();
            }
            
        }

        private void ispis_Click(object sender, EventArgs e)
        {
            foreach(Vozilo v in VoziloList)
            {
                txtIspis.AppendText(v.ToString());
            }
        }

        private void obrada_Click(object sender, EventArgs e)
        {
            foreach (Vozilo v in VoziloList)
            {
                if(v.Vrsta =="Avilon")
                {
                    v.VoziPo = "Zrak";
                }
                else if(v.Vrsta=="Automobil")
                {
                    v.VoziPo = "Cesta";
                }
                else
                {
                    v.VoziPo = "Voda";
                }
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void marka_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
