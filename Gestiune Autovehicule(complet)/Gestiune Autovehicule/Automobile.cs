using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestiune_Autovehicule
{
    public partial class Automobile : Form
    {
        String provider = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Automobile.accdb;";
        Auto[] automobile = new Auto[4];
        public static int id;
        public static String marca;
        public static float putere;
        int count;

        public Automobile()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            automobile[0] = new Auto(1, "Mitsubishi", 450);
            automobile[1] = new Auto(2, "BMW", 400);
            automobile[2] = new Auto(3, "Toyota", 350);
            automobile[3] = new Auto(4, "Mercedes", 450);
            ListViewItem item = new ListViewItem(Convert.ToString(automobile[0].id));
            item.SubItems.Add(automobile[0].marca);
            item.SubItems.Add(Convert.ToString(automobile[0].Putere));
            lvAuto.Items.Add(item);
            count = 0;
            tbOrdine.Text = "1 / 4";

            foreach(Auto a in automobile)
            {
                cbMarci.Items.Add(a.marca);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            if (count < 3)
            {
                lvAuto.Items.Clear();
                count++;
                ListViewItem item = new ListViewItem(Convert.ToString(automobile[count].id));
                item.SubItems.Add(automobile[count].marca);
                item.SubItems.Add(Convert.ToString(automobile[count].Putere));
                lvAuto.Items.Add(item);
                int nr = count + 1;
                tbOrdine.Text = nr + " / 4"; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            if (count > 0)
            {
                lvAuto.Items.Clear();
                count--;
                ListViewItem item = new ListViewItem(Convert.ToString(automobile[count].id));
                item.SubItems.Add(automobile[count].marca);
                item.SubItems.Add(Convert.ToString(automobile[count].Putere));
                lvAuto.Items.Add(item);
                int nr = count + 1;
                tbOrdine.Text = nr + " / 4"; 
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
            {
                if (count < 3)
                {
                    lvAuto.Items.Clear();
                    count++;
                    ListViewItem item = new ListViewItem(Convert.ToString(automobile[count].id));
                    item.SubItems.Add(automobile[count].marca);
                    item.SubItems.Add(Convert.ToString(automobile[count].Putere));
                    lvAuto.Items.Add(item);
                    int nr = count + 1;
                    tbOrdine.Text = nr + " / 4";
                }
            }

            if (e.KeyData == Keys.Down)
            {
                if (count > 0)
                {
                    lvAuto.Items.Clear();
                    count--;
                    ListViewItem item = new ListViewItem(Convert.ToString(automobile[count].id));
                    item.SubItems.Add(automobile[count].marca);
                    item.SubItems.Add(Convert.ToString(automobile[count].Putere));
                    lvAuto.Items.Add(item);
                    int nr = count + 1;
                    tbOrdine.Text = nr + " / 4";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Editare ed = new Editare(automobile[count].id, automobile[count].marca, automobile[count].Putere);
            ed.ShowDialog();
            automobile[count] = new Auto(id, marca, putere);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(provider);
            conexiune.Open();
            OleDbCommand comanda;
            String sql = "DELETE FROM Auto WHERE ID>0";
            comanda = new OleDbCommand(sql, conexiune);
            comanda.ExecuteNonQuery();
            foreach (Auto a in automobile)
            {
                sql = "INSERT INTO Auto VALUES("+a.id+", '"+a.marca+"', "+a.Putere+")";
                comanda = new OleDbCommand(sql, conexiune);                
                comanda.ExecuteNonQuery();
            }
            conexiune.Close();
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(provider);           
            String sql = "SELECT ID, Marca, Putere FROM Auto";
            OleDbCommand comanda = new OleDbCommand(sql, conexiune);
            conexiune.Open();
            OleDbDataReader reader = comanda.ExecuteReader();
            int i=0;
            while (reader.Read())
            {
                automobile[i] = new Auto(Convert.ToInt32(reader["ID"]), Convert.ToString(reader["Marca"]), (float)Convert.ToDecimal(reader["Putere"]));
                i++;
            }
        }

        private void graficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String s = "";
            foreach (Auto a in automobile)
            {
                s += a.Putere + " ";
            }
            Grafic g = new Grafic(s);
            g.ShowDialog();
        }

        private void butonClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String sir = Clipboard.GetText();
            String[] impartit = sir.Split(';');
            try
            {
                Auto a = new Auto(Convert.ToInt32(impartit[0]), Convert.ToString(impartit[1]), (float)Convert.ToDecimal(impartit[2]));
                MessageBox.Show(a.id + " " + a.marca + " " + a.Putere);
            }
            catch (Exception)
            {
                MessageBox.Show("Ce sa copiat in Clipboard, nu corespunde cu structura unui obiect Auto!\nExemplu: 1;Mitsubishi;450");
            }     
        }

        private void cbMarci_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
