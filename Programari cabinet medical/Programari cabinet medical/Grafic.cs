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
    public partial class Grafic : Form
    {
        public Grafic()
        {
            InitializeComponent();
        }

        private void Grafic_Paint(object sender, PaintEventArgs e)
        {
            int intern = 0;
            int recuperare = 0;
            int orl = 0;
            int max1;
            int max2;

            foreach (Programare p in Programari.cab.ListaProgramari)
            {
                if (Convert.ToString(p.Specialitate1) == "Interna")
                {
                    intern++;
                }
                if (Convert.ToString(p.Specialitate1) == "Recuperare")
                {
                    recuperare++;
                }
                if (Convert.ToString(p.Specialitate1) == "Orl")
                {
                    orl++;
                }
            }
            if (intern > recuperare)
            {
                max1 = intern;
            }
            else
            {
                max1 = recuperare;
            }
            if (recuperare > orl)
            {
                max2 = recuperare;
            }
            else
            {
                max2 = orl;
            }
            if (max1 < max2)
            {
                max1 = max2;
            }

            SolidBrush sb = new SolidBrush(Color.Blue);
            Graphics grafica = this.CreateGraphics();
            Rectangle[] rec = new Rectangle[3];
            rec[0] = new Rectangle(5, 10, 5, intern*20);
            rec[1] = new Rectangle(10, 10, 5, recuperare*20);
            rec[2] = new Rectangle(15, 10, 5, orl*20);
            grafica.FillRectangles(sb, rec);
            sb.Dispose();
            grafica.Dispose();
        }
    }
}
