using GraphLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW
{
    public partial class Form1 : Form
    {
        List<Bilet> bilete;
        public Form1()
        {
            InitializeComponent();
            bilete = new List<Bilet>();
           Echipa dinamo = new Echipa("FC Dinamo Bucuresti", "romana", 11);
            Echipa fcsb = new Echipa("fcsb", "romana", 11);
            Echipa fcb = new Echipa("FC Barcelona", "spaniola", 11);
            Echipa am = new Echipa("Atletico Madid", "spaniola", 11);
            Meci m1 = new Meci(01, DateTime.Now, "Fotbal", "FC Dinamo Bucuresti VS FCSB", fcsb, dinamo, 5, 2);
            Meci m2 = new Meci(01, DateTime.Now, "Fotbal", "FC Barcelona VS Atletico Madrid", fcb, am, 3, 3);
            Pariu p1 = new Pariu("2", m1, 3.25);
            Pariu p2 = new Pariu("1", m2, 1.37);
            Pariu[] vPariu = { p1, p2 };
            Bilet b1 = new Bilet(01, DateTime.Now, 10, 2, vPariu);
            ListViewItem lvi1 = new ListViewItem(b1.id.ToString());
            lvi1.SubItems.Add(b1.biletPrintat.ToString());
            lvi1.SubItems.Add(b1.pret.ToString());
            lvi1.SubItems.Add(b1.sansaCastig().ToString());
            lvi1.SubItems.Add(b1.nrMeciuri.ToString());
            listView1.Items.Add(lvi1);
            lvi1.Tag = b1;
        }

        private void g(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAfisareBilet_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            listView1.SelectedIndexChanged += new EventHandler(fm.ActualizeazaControale);
            fm.ActualizeazaControale(listView1, e);
            fm.parinte = this;
            fm.Show();

        }
        public void UpdateItems()
        {
            foreach (ListViewItem lvi in listView1.Items)
            {
                Bilet b1 = (Bilet)lvi.Tag;
                lvi.Text = b1.id.ToString();
                lvi.SubItems[1].Text = (b1.biletPrintat).ToString();
                lvi.SubItems[2].Text = b1.pret.ToString();
                lvi.SubItems[3].Text = b1.sansaCastig().ToString();
                lvi.SubItems[4].Text = b1.nrMeciuri.ToString();
                bilete.Add(b1);
            }
         
            // foreach 
        }

        private void buttonAdaugaBilet_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(new string[] { "", "", "", "", "" });
            listView1.Items.Add(lvi);
            Bilet b = new Bilet(0, DateTime.Now, 0, 0, null);
            lvi.Tag = b;
            lvi.Selected = true;
            Form2 fm = new Form2();
            fm.bilet = b;
            fm.parinte = this;
            fm.Text = "Adauga bilet";
            fm.ShowDialog();

            if (fm.DialogResult != DialogResult.OK) ;// lvi.Remove();


        }

        private void toolStripMenuItemAdaugaBilet_Click(object sender, EventArgs e)
        {
            buttonAdaugaBilet_Click(sender, e);
        }

        private void toolStripMenuItemModificaBilet_Click(object sender, EventArgs e)
        {
            buttonAfisareBilet_Click(sender, e);
        }

        private void toolStripMenuItemStergeBilet_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Bilet m = (Bilet)listView1.SelectedItems[0].Tag;
                DialogResult rezultat = MessageBox.Show("Sunteti sigur ca doriti stergerea biletului   ?",
                    "Confirmare stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rezultat == DialogResult.Yes) listView1.SelectedItems[0].Remove();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form4 form = new Form4(bilete);
            form.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4(bilete);
            form.ShowDialog();
        }
    }
    


}
