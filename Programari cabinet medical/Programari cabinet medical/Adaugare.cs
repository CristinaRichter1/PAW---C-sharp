using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Programari_cabinet_medical
{
    public partial class Adaugare : Form
    {
        int count;

        public Adaugare()
        {
            InitializeComponent();
        }

        public Adaugare(int nr)
        {
            InitializeComponent();
            count = nr;
        }

        private void Adaugare_Load(object sender, EventArgs e)
        {
            cbSpecializare.Items.Add("Interna");
            cbSpecializare.Items.Add("Recuperare");
            cbSpecializare.Items.Add("Orl");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbOra.Text) > 7 && Convert.ToInt32(tbOra.Text) < 19)
            {
                String data = dtpData.Text;
                data += " " + tbOra.Text + ":00";
                DateTime dt = Convert.ToDateTime(data);
                if (cbSpecializare.Text == "Interna")
                {
                    Programari.cab.AdaugaProgramare(new Programare(count, tbNumePacient.Text, dt, 0));
                }
                if (cbSpecializare.Text == "Recuperare")
                {
                    Programari.cab.AdaugaProgramare(new Programare(count, tbNumePacient.Text, dt, 1));
                }
                if (cbSpecializare.Text == "Orl")
                {
                    Programari.cab.AdaugaProgramare(new Programare(count, tbNumePacient.Text, dt, 2));
                }
                MessageBox.Show("Programarea a fost adaugata!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Alege o ora intre 8:00 - 18:00!");
            }
        }
    }
}
