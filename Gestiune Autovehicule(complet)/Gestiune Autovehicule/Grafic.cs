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
    public partial class Grafic : Form
    {
        String puteri;

        public Grafic()
        {
            InitializeComponent();
        }

        public Grafic(String s)
        {
            InitializeComponent();
            puteri = s;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            String[] impartit = puteri.Split(' ');
            int a = 10;
            foreach(String sir in impartit)
            {
                if (sir != "")
                {
                    SolidBrush sb = new SolidBrush(Color.Blue);
                    Graphics grafic = e.Graphics;
                    grafic.FillRectangle(sb, new Rectangle(10, a, Convert.ToInt32(sir), 15));
                    a = a + 25;
                }
            }
        }
    }
}
