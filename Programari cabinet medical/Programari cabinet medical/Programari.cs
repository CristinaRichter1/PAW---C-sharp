using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Programari_cabinet_medical
{
    public partial class Programari : Form
    {
        String provider = "Provider = Microsoft.ACE.OLEDB.12.0; Data source = Programari.accdb;";
        public static Cabinet cab = new Cabinet();

        public Programari()
        {
            InitializeComponent();
        }

        private void Programari_Load(object sender, EventArgs e)
        {
            Programare[] p = new Programare[3];
            Programare p1 = new Programare(1, "Popescu Ion", Convert.ToDateTime("16/05/2015 15:00"), 2);
            Programare p2 = new Programare(2, "Mangu Bogdan", Convert.ToDateTime("25/08/2015 12:00"), 1);
            Programare p3 = new Programare(3, "Vrancea Marian", Convert.ToDateTime("10/07/2015 13:00"), 0);
            cab.AdaugaProgramare(p1);
            cab.AdaugaProgramare(p2);
            cab.AdaugaProgramare(p3);
            p[0] = p1; p[1] = p2; p[2] = p3;
            for (int i = 0; i < 3; i++)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(p[i].Cod));
                item.SubItems.Add(p[i].NumePacient);
                item.SubItems.Add(Convert.ToString(p[i].Data));
                item.SubItems.Add(Convert.ToString(p[i].Specialitate1));
                lvProgramari.Items.Add(item);
            }
        }

        private void adaugareExamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int nr;
            if (cab.NumarProgramari == 0)
            {
                nr = 0;
            }
            else
            {
                nr = cab.NumarProgramari + 1;
            }
            Adaugare ad = new Adaugare(nr);
            ad.ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvProgramari.Items.Clear();
            foreach (Programare p in cab.ListaProgramari)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(p.Cod));
                item.SubItems.Add(p.NumePacient);
                item.SubItems.Add(Convert.ToString(p.Data));
                item.SubItems.Add(Convert.ToString(p.Specialitate1));
                lvProgramari.Items.Add(item);
            }
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(provider);
            OleDbCommand comanda;
            String sql;
            conexiune.Open();
            sql = "DELETE FROM Programare WHERE Cod>0";
            comanda = new OleDbCommand(sql, conexiune);
            comanda.ExecuteNonQuery();           
            foreach (Programare p in cab.ListaProgramari)
            {
                sql = "INSERT INTO Programare VALUES(" + p.Cod + ", '" + p.NumePacient + "', '" + p.Data + "', '" + p.Specialitate1 + "')";
                comanda = new OleDbCommand(sql, conexiune);
                comanda.ExecuteNonQuery();
            }
            conexiune.Close();
        }

        private void restaurareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cab.ListaProgramari.Clear();
            OleDbConnection conexiune = new OleDbConnection(provider);
            String sql = "SELECT Cod, NumePacient, Data, Specialitate FROM Programare";
            OleDbCommand comanda = new OleDbCommand(sql, conexiune);
            conexiune.Open();
            OleDbDataReader reader = comanda.ExecuteReader();
            while (reader.Read())
            {
                if (Convert.ToString(reader["Specialitate"]) == "Interna")
                {
                    cab.AdaugaProgramare(new Programare(Convert.ToInt32(reader["Cod"]), Convert.ToString(reader["NumePacient"]), Convert.ToDateTime(reader["Data"]), 0));
                }
                if (Convert.ToString(reader["Specialitate"]) == "Recuperare")
                {
                    cab.AdaugaProgramare(new Programare(Convert.ToInt32(reader["Cod"]), Convert.ToString(reader["NumePacient"]), Convert.ToDateTime(reader["Data"]), 1));
                }
                if (Convert.ToString(reader["Specialitate"]) == "Orl")
                {
                    cab.AdaugaProgramare(new Programare(Convert.ToInt32(reader["Cod"]), Convert.ToString(reader["NumePacient"]), Convert.ToDateTime(reader["Data"]), 2));
                }
            }
            conexiune.Close();
        }

        private void vizualizareGraficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grafic gr = new Grafic();
            gr.ShowDialog();
        }
    }
}
