using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestiune_Autovehicule
{
    public partial class Editare : Form
    {
        int ID;
        String marca;
        float putere;

        public Editare()
        {
            InitializeComponent();
        }

        public Editare(int i, String m, float p)
        {
            InitializeComponent();
            this.ID = i;
            this.marca = m;
            this.putere = p;
        }

        private void Editare_Load(object sender, EventArgs e)
        {
            tbID.Text = Convert.ToString(ID);
            tbMarca.Text = marca;
            tbPutere.Text = Convert.ToString(putere);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Automobile.id = Convert.ToInt32(tbID.Text);
            Automobile.marca = tbMarca.Text;
            Automobile.putere = (float)Convert.ToDecimal(tbPutere.Text);
            this.Close();
        }
    }
}
