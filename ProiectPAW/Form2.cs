using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW
{

    public partial class Form2 : Form
    {
        Meci m1;
        public Bilet bilet;
        public Form1 parinte;
        public Form2()
        {
            InitializeComponent();
        }
        public void ActualizeazaControale(object sender, EventArgs e)
        {

            ListView lista = (ListView)sender;
            bilet = null;
            if (lista.SelectedItems.Count > 0)
                bilet = (Bilet)lista.SelectedItems[0].Tag;
            if (bilet != null)
            {
                buttonAdaugaBilet.Text = "Modifica Bilet";
                textBoxPret.Text = bilet.pret.ToString();

                for (int i = 0; i < bilet.nrMeciuri; i++)
                {
                    ListViewItem lvi2 = new ListViewItem(bilet.pariuri[i].meci.denumire);
                    lvi2.SubItems.Add((bilet.pariuri[i].simbol));
                    lvi2.SubItems.Add(bilet.pariuri[i].cota.ToString());
                    lvi2.SubItems.Add(bilet.pariuri[i].meci.oraMeci.ToString());
                    listViewBilet.Items.Add(lvi2);
                }
                textBoxCota.Text = bilet.totalCota().ToString();
                textBoxSansaCastig.Text = bilet.sansaCastig().ToString();
            }



        }

        private void buttonAdaugaBilet_Click(object sender, EventArgs e)
        {

            //  Bilet b1 = new Bilet(bilet.id, bilet.biletPrintat, bilet.pret, bilet.nrMeciuri + 1, bilet.pariuri);
            Pariu[] pariu = new Pariu[bilet.pariuri.Count()];
            //    Bilet b1 = new Bilet(bilet.id, bilet.biletPrintat, bilet.pret, bilet.nrMeciuri + 1,bilet.pariuri);

            if (bilet != null)
            {
                int i = 0;
                bilet.biletPrintat = DateTime.Now;
                bilet.pret = Convert.ToDouble(textBoxPret.Text);
                bilet.nrMeciuri = listViewBilet.Items.Count;

                bilet.pariuri = new Pariu[bilet.nrMeciuri];
                foreach (ListViewItem item in listViewBilet.Items)
                {
                    Echipa e1 = new Echipa(item.SubItems[0].Text, "", 11);
                    Echipa e2 = new Echipa(item.SubItems[0].Text, "", 11);
                    Meci m = new Meci(i, Convert.ToDateTime(item.SubItems[3].Text.ToString()), "fotbal", item.SubItems[0].Text, e1, e2, 0, 0);
                    bilet.pariuri[i] = new Pariu(item.SubItems[0].Text, m, Convert.ToDouble(item.SubItems[2].Text.ToString()));
                    //bilet.pariuri[i].denumire = (item.SubItems[0].Text );
                    //bilet.pariuri[i].meci.oraMeci = Convert.ToDateTime(item.SubItems[3].Text.ToString());
                    //bilet.pariuri[i].cota = Convert.ToDouble(item.SubItems[2].Text.ToString());
                    bilet.pariuri[i].simbol = item.SubItems[1].Text;

                    //bilet.pariuri[i].meci.denumire = item.SubItems[0].Text.ToString();
                    //bilet.pariuri[i].meci.oraMeci = Convert.ToDateTime(item.SubItems[3].Text.ToString());
                    //bilet.pariuri[i].cota = Convert.ToDouble(item.SubItems[2].Text.ToString());
                    //bilet.pariuri[i].simbol = item.SubItems[1].Text
                    i++;

                }
                // listViewBilet.Tag = bilet;
                parinte.UpdateItems();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var fileLines = File.ReadAllLines(@"D:\Programare\C#\ProiectPAW\Oferta Fotbal.txt");

            for (int i = 0; i < fileLines.Length; i += 16)
            {
                Random rand = new Random();
                listViewOferta.Items.Add(
                    new ListViewItem(new[]
                    {
                fileLines[i],
               fileLines[i+1],
               fileLines[i+2],
               fileLines[i+3],
               fileLines[i+4],
               fileLines[i+5],
               fileLines[i+6],
               fileLines[i+7],
               fileLines[i+8],
               fileLines[i+9],
               fileLines[i+10],
               fileLines[i+11],
               fileLines[i+12],
               fileLines[i+13],
               fileLines[i+14],
               fileLines[i+15]

                    }));




                // Resize the columns
            }
        }

        private void listViewOferta_ItemDrag(object sender, ItemDragEventArgs e)
        {
            var items = new List<ListViewItem>();

            items.Add((ListViewItem)e.Item);

            foreach (ListViewItem lvi in listViewOferta.SelectedItems)
            {
                if (!items.Contains(lvi))
                {
                    items.Add(lvi);
                }
            }
            // pass the items to move...
            listViewOferta.DoDragDrop(items, DragDropEffects.Copy);
        }

        private void listViewBilet_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void listViewBilet_DragDrop(object sender, DragEventArgs e)
        {
            int id = 0;
            if (checkBox02G.Checked)
            {
                if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
                {
                    var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                    // move to dest LV
                    foreach (ListViewItem lvi in items)
                    {

                        // LVI obj can only belong to one LVI, remove
                        // lvi.ListView.Items.Remove(lvi)
                        Random r = new Random();
                        Echipa e1 = new Echipa(lvi.SubItems[1].Text, "", 11);
                        Echipa e2 = new Echipa(lvi.SubItems[2].Text, "", 11);
                        Meci m1 = new Meci(id++, Convert.ToDateTime(lvi.SubItems[3].Text.ToString()), "", lvi.SubItems[0].Text, e1, e2, r.Next(0, 5), r.Next(0, 5));
                        Pariu np1 = new Pariu("0-2", m1, Convert.ToDouble(lvi.SubItems[7].Text));
                        //  Bilet b1 = new Bilet(id++, DateTime.Now, Convert.ToInt32(textBoxPret.Text),listViewBilet.Items.Count,
                        listViewBilet.Items.Add(new ListViewItem(new[] { lvi.SubItems[1].Text + " VS " + lvi.SubItems[2].Text, np1.simbol, np1.cota.ToString(), m1.oraMeci.ToString() }));
                    }
                }
                checkBox02G.Checked = false;
            }
            else if (checkBox13G.Checked)
            {
                if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
                {
                    var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                    // move to dest LV
                    foreach (ListViewItem lvi in items)
                    {

                        // LVI obj can only belong to one LVI, remove
                        // lvi.ListView.Items.Remove(lvi)
                        Random r = new Random();
                        Echipa e1 = new Echipa(lvi.SubItems[1].Text, "", 11);
                        Echipa e2 = new Echipa(lvi.SubItems[2].Text, "", 11);
                        Meci m1 = new Meci(id++, Convert.ToDateTime(lvi.SubItems[3].Text.ToString()), "", lvi.SubItems[0].Text, e1, e2, r.Next(0, 5), r.Next(0, 5));
                        Pariu np1 = new Pariu("1-3", m1, Convert.ToDouble(lvi.SubItems[8].Text));
                        //  Bilet b1 = new Bilet(id++, DateTime.Now, Convert.ToInt32(textBoxPret.Text),listViewBilet.Items.Count,
                        listViewBilet.Items.Add(new ListViewItem(new[] { lvi.SubItems[1].Text + " VS " + lvi.SubItems[2].Text, np1.simbol, np1.cota.ToString(), m1.oraMeci.ToString() }));
                    }
                }
                checkBox13G.Checked = false;
            }
            else if (checkBox35G.Checked)
            {
                if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
                {
                    var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                    // move to dest LV
                    foreach (ListViewItem lvi in items)
                    {

                        // LVI obj can only belong to one LVI, remove
                        // lvi.ListView.Items.Remove(lvi)
                        Random r = new Random();
                        Echipa e1 = new Echipa(lvi.SubItems[1].Text, "", 11);
                        Echipa e2 = new Echipa(lvi.SubItems[2].Text, "", 11);
                        Meci m1 = new Meci(id++, Convert.ToDateTime(lvi.SubItems[3].Text.ToString()), "", lvi.SubItems[0].Text, e1, e2, r.Next(0, 5), r.Next(0, 5));
                        Pariu np1 = new Pariu("3-5", m1, Convert.ToDouble(lvi.SubItems[9].Text));
                        //  Bilet b1 = new Bilet(id++, DateTime.Now, Convert.ToInt32(textBoxPret.Text),listViewBilet.Items.Count,
                        listViewBilet.Items.Add(new ListViewItem(new[] { lvi.SubItems[1].Text + " VS " + lvi.SubItems[2].Text, np1.simbol, np1.cota.ToString(), m1.oraMeci.ToString() }));
                    }
                }
                checkBox35G.Checked = false;
            }
            else if (checkBox1Final.Checked)
            {
                if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
                {
                    var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                    // move to dest LV
                    foreach (ListViewItem lvi in items)
                    {

                        // LVI obj can only belong to one LVI, remove
                        // lvi.ListView.Items.Remove(lvi)
                        Random r = new Random();
                        Echipa e1 = new Echipa(lvi.SubItems[1].Text, "", 11);
                        Echipa e2 = new Echipa(lvi.SubItems[2].Text, "", 11);
                        Meci m1 = new Meci(id++, Convert.ToDateTime(lvi.SubItems[3].Text.ToString()), "", lvi.SubItems[0].Text, e1, e2, r.Next(0, 5), r.Next(0, 5));
                        Pariu np1 = new Pariu("1", m1, Convert.ToDouble(lvi.SubItems[4].Text));
                        //  Bilet b1 = new Bilet(id++, DateTime.Now, Convert.ToInt32(textBoxPret.Text),listViewBilet.Items.Count,
                        listViewBilet.Items.Add(new ListViewItem(new[] { lvi.SubItems[1].Text + " VS " + lvi.SubItems[2].Text, np1.simbol, np1.cota.ToString(), m1.oraMeci.ToString() }));
                    }
                }
                checkBox1Final.Checked = false;
            }
            else if (checkBox2Final.Checked)
            {
                if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
                {
                    var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                    // move to dest LV
                    foreach (ListViewItem lvi in items)
                    {

                        // LVI obj can only belong to one LVI, remove
                        // lvi.ListView.Items.Remove(lvi)
                        Random r = new Random();
                        Echipa e1 = new Echipa(lvi.SubItems[1].Text, "", 11);
                        Echipa e2 = new Echipa(lvi.SubItems[2].Text, "", 11);
                        Meci m1 = new Meci(id++, Convert.ToDateTime(lvi.SubItems[3].Text.ToString()), "", lvi.SubItems[0].Text, e1, e2, r.Next(0, 5), r.Next(0, 5));
                        Pariu np1 = new Pariu("2", m1, Convert.ToDouble(lvi.SubItems[5].Text));
                        //  Bilet b1 = new Bilet(id++, DateTime.Now, Convert.ToInt32(textBoxPret.Text),listViewBilet.Items.Count,
                        listViewBilet.Items.Add(new ListViewItem(new[] { lvi.SubItems[1].Text + " VS " + lvi.SubItems[2].Text, np1.simbol, np1.cota.ToString(), m1.oraMeci.ToString() }));
                    }
                }
                checkBox2Final.Checked = false;
            }
            else if (checkBoxXFInal.Checked)
            {
                if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
                {
                    var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                    // move to dest LV
                    foreach (ListViewItem lvi in items)
                    {

                        // LVI obj can only belong to one LVI, remove
                        // lvi.ListView.Items.Remove(lvi)
                        Random r = new Random();
                        Echipa e1 = new Echipa(lvi.SubItems[1].Text, "", 11);
                        Echipa e2 = new Echipa(lvi.SubItems[2].Text, "", 11);
                        Meci m1 = new Meci(id++, Convert.ToDateTime(lvi.SubItems[3].Text.ToString()), "", lvi.SubItems[0].Text, e1, e2, r.Next(0, 5), r.Next(0, 5));
                        Pariu np1 = new Pariu("X", m1, Convert.ToDouble(lvi.SubItems[6].Text));
                        //  Bilet b1 = new Bilet(id++, DateTime.Now, Convert.ToInt32(textBoxPret.Text),listViewBilet.Items.Count,
                        listViewBilet.Items.Add(new ListViewItem(new[] { lvi.SubItems[1].Text + " VS " + lvi.SubItems[2].Text, np1.simbol, np1.cota.ToString(), m1.oraMeci.ToString() }));
                    }
                }

                checkBoxXFInal.Checked = false;
            }
            else if (checkBoxP15.Checked)
            {
                if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
                {
                    var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                    // move to dest LV
                    foreach (ListViewItem lvi in items)
                    {

                        // LVI obj can only belong to one LVI, remove
                        // lvi.ListView.Items.Remove(lvi)
                        Random r = new Random();
                        Echipa e1 = new Echipa(lvi.SubItems[1].Text, "", 11);
                        Echipa e2 = new Echipa(lvi.SubItems[2].Text, "", 11);
                        Meci m1 = new Meci(id++, Convert.ToDateTime(lvi.SubItems[3].Text.ToString()), "", lvi.SubItems[0].Text, e1, e2, r.Next(0, 5), r.Next(0, 5));
                        Pariu np1 = new Pariu("P 1.5", m1, Convert.ToDouble(lvi.SubItems[10].Text));
                        //  Bilet b1 = new Bilet(id++, DateTime.Now, Convert.ToInt32(textBoxPret.Text),listViewBilet.Items.Count,
                        listViewBilet.Items.Add(new ListViewItem(new[] { lvi.SubItems[1].Text + " VS " + lvi.SubItems[2].Text, np1.simbol, np1.cota.ToString(), m1.oraMeci.ToString() }));
                    }
                }
                checkBoxP15.Checked = false;
            }
            else if (checkBoxP25.Checked)
            {
                if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
                {
                    var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                    // move to dest LV
                    foreach (ListViewItem lvi in items)
                    {

                        // LVI obj can only belong to one LVI, remove
                        // lvi.ListView.Items.Remove(lvi)
                        Random r = new Random();
                        Echipa e1 = new Echipa(lvi.SubItems[1].Text, "", 11);
                        Echipa e2 = new Echipa(lvi.SubItems[2].Text, "", 11);
                        Meci m1 = new Meci(id++, Convert.ToDateTime(lvi.SubItems[3].Text.ToString()), "", lvi.SubItems[0].Text, e1, e2, r.Next(0, 5), r.Next(0, 5));
                        Pariu np1 = new Pariu("P 2.5", m1, Convert.ToDouble(lvi.SubItems[11].Text));
                        //  Bilet b1 = new Bilet(id++, DateTime.Now, Convert.ToInt32(textBoxPret.Text),listViewBilet.Items.Count,
                        listViewBilet.Items.Add(new ListViewItem(new[] { lvi.SubItems[1].Text + " VS " + lvi.SubItems[2].Text, np1.simbol, np1.cota.ToString(), m1.oraMeci.ToString() }));
                    }
                }
                checkBoxP25.Checked = false;
            }
            else if (checkBoxP35.Checked)
            {
                if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
                {
                    var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                    // move to dest LV
                    foreach (ListViewItem lvi in items)
                    {

                        // LVI obj can only belong to one LVI, remove
                        // lvi.ListView.Items.Remove(lvi)
                        Random r = new Random();
                        Echipa e1 = new Echipa(lvi.SubItems[1].Text, "", 11);
                        Echipa e2 = new Echipa(lvi.SubItems[2].Text, "", 11);
                        Meci m1 = new Meci(id++, Convert.ToDateTime(lvi.SubItems[3].Text.ToString()), "", lvi.SubItems[0].Text, e1, e2, r.Next(0, 5), r.Next(0, 5));
                        Pariu np1 = new Pariu("P 3.5", m1, Convert.ToDouble(lvi.SubItems[12].Text));
                        //  Bilet b1 = new Bilet(id++, DateTime.Now, Convert.ToInt32(textBoxPret.Text),listViewBilet.Items.Count,
                        listViewBilet.Items.Add(new ListViewItem(new[] { lvi.SubItems[1].Text + " VS " + lvi.SubItems[2].Text, np1.simbol, np1.cota.ToString(), m1.oraMeci.ToString() }));
                    }
                }
                checkBoxP35.Checked = false;
            }
            else if (CheckBoxGG.Checked)
            {
                if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
                {
                    var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                    // move to dest LV
                    foreach (ListViewItem lvi in items)
                    {

                        // LVI obj can only belong to one LVI, remove
                        // lvi.ListView.Items.Remove(lvi)
                        Random r = new Random();
                        Echipa e1 = new Echipa(lvi.SubItems[1].Text, "", 11);
                        Echipa e2 = new Echipa(lvi.SubItems[2].Text, "", 11);
                        Meci m1 = new Meci(id++, Convert.ToDateTime(lvi.SubItems[3].Text.ToString()), "", lvi.SubItems[0].Text, e1, e2, r.Next(0, 5), r.Next(0, 5));
                        Pariu np1 = new Pariu("GG", m1, Convert.ToDouble(lvi.SubItems[13].Text));
                        //  Bilet b1 = new Bilet(id++, DateTime.Now, Convert.ToInt32(textBoxPret.Text),listViewBilet.Items.Count,
                        listViewBilet.Items.Add(new ListViewItem(new[] { lvi.SubItems[1].Text + " VS " + lvi.SubItems[2].Text, np1.simbol, np1.cota.ToString(), m1.oraMeci.ToString() }));
                    }
                }
                CheckBoxGG.Checked = false;
            }
            else if (checkBoxGG3.Checked)
            {
                if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
                {
                    var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                    // move to dest LV
                    foreach (ListViewItem lvi in items)
                    {

                        // LVI obj can only belong to one LVI, remove
                        // lvi.ListView.Items.Remove(lvi)
                        Random r = new Random();
                        Echipa e1 = new Echipa(lvi.SubItems[1].Text, "", 11);
                        Echipa e2 = new Echipa(lvi.SubItems[2].Text, "", 11);
                        Meci m1 = new Meci(id++, Convert.ToDateTime(lvi.SubItems[3].Text.ToString()), "", lvi.SubItems[0].Text, e1, e2, r.Next(0, 5), r.Next(0, 5));
                        Pariu np1 = new Pariu("GG3+", m1, Convert.ToDouble(lvi.SubItems[14].Text));
                        //  Bilet b1 = new Bilet(id++, DateTime.Now, Convert.ToInt32(textBoxPret.Text),listViewBilet.Items.Count,
                        listViewBilet.Items.Add(new ListViewItem(new[] { lvi.SubItems[1].Text + " VS " + lvi.SubItems[2].Text, np1.simbol, np1.cota.ToString(), m1.oraMeci.ToString() }));
                    }
                }
                checkBoxGG3.Checked = false;
            }

            else if (checkBoxNGG.Checked)
            {
                if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
                {
                    var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                    // move to dest LV
                    foreach (ListViewItem lvi in items)
                    {

                        // LVI obj can only belong to one LVI, remove
                        // lvi.ListView.Items.Remove(lvi)
                        Random r = new Random();
                        Echipa e1 = new Echipa(lvi.SubItems[1].Text, "", 11);
                        Echipa e2 = new Echipa(lvi.SubItems[2].Text, "", 11);
                        Meci m1 = new Meci(id++, Convert.ToDateTime(lvi.SubItems[3].Text.ToString()), "", lvi.SubItems[0].Text, e1, e2, r.Next(0, 5), r.Next(0, 5));
                        Pariu np1 = new Pariu("NGG", m1, Convert.ToDouble(lvi.SubItems[15].Text));
                        //  Bilet b1 = new Bilet(id++, DateTime.Now, Convert.ToInt32(textBoxPret.Text),listViewBilet.Items.Count,
                        listViewBilet.Items.Add(new ListViewItem(new[] { lvi.SubItems[1].Text + " VS " + lvi.SubItems[2].Text, np1.simbol, np1.cota.ToString(), m1.oraMeci.ToString() }));
                        textBoxCota.Text = (bilet.totalCota() + np1.cota).ToString();
                    }
                }

                checkBoxNGG.Checked = false;
            }
            else
                errorProvider1.SetError(buttonAdaugaBilet, "Ups! Ai uitat ce tip de pariu vrei sa faci");

        }

        private void toolStripMenuItemOfertaFotbal_Click(object sender, EventArgs e)
        {
            listViewOferta.Items.Clear();
            button1_Click(sender, e);
        }

        private void toolStripMenuItemOfertaHandbal_Click(object sender, EventArgs e)
        {

            listViewOferta.Items.Clear();
            var fileLines = File.ReadAllLines(@"D:\Programare\C#\ProiectPAW\Oferta Handball.txt");

            for (int i = 0; i < fileLines.Length; i += 16)
            {
                Random rand = new Random();
                listViewOferta.Items.Add(
                    new ListViewItem(new[]
                    {
                        fileLines[i],
                        fileLines[i + 1],
                        fileLines[i + 2],
                        fileLines[i + 3],
                        fileLines[i + 4],
                        fileLines[i + 5],
                        fileLines[i + 6],
                        fileLines[i + 7],
                        fileLines[i + 8],
                        fileLines[i + 9],
                        fileLines[i + 10],
                        fileLines[i + 11],
                        fileLines[i + 12],
                        fileLines[i + 13],
                        fileLines[i + 14],
                        fileLines[i + 15]
                    }));
            }
        }

        private void toolStripMenuItemOfertaRugby_Click(object sender, EventArgs e)
        {
            listViewOferta.Items.Clear();

            var fileLines = File.ReadAllLines(@"D:\Programare\C#\ProiectPAW\Oferta Rugby.txt");

            for (int i = 0; i < fileLines.Length; i += 16)
            {
                Random rand = new Random();
                listViewOferta.Items.Add(
                    new ListViewItem(new[]
                    {
                        fileLines[i],
                        fileLines[i + 1],
                        fileLines[i + 2],
                        fileLines[i + 3],
                        fileLines[i + 4],
                        fileLines[i + 5],
                        fileLines[i + 6],
                        fileLines[i + 7],
                        fileLines[i + 8],
                        fileLines[i + 9],
                        fileLines[i + 10],
                        fileLines[i + 11],
                        fileLines[i + 12],
                        fileLines[i + 13],
                        fileLines[i + 14],
                        fileLines[i + 15]
                    }));
            }
        }

        private void textBoxPret_Validating(object sender, CancelEventArgs e)
        {
            {
                string errorMsg;
                if (!ValidPret(textBoxPret.Text, out errorMsg))
                {
                    // Cancel the event and select the text to be corrected by the user.
                    e.Cancel = true;
                    textBoxPret.Select(0, textBoxPret.Text.Length);

                    // Set the ErrorProvider error with the text to display. 
                    this.errorProvider1.SetError(textBoxPret, errorMsg);
                }
            }
        }
        public bool ValidPret(string pret, out string errorMessage)
        {
            // Confirm that the email address string is not empty.
            if (textBoxPret.Text.Length == 0)
            {
                errorMessage = "Nu ai introdus pretul Corect";
                return false;
            }
            if (Convert.ToInt32(pret) > 0) {
                errorMessage = "";
                return true;
            }
            errorMessage = "Pretul nu a fost introdus corect ! ";

            return false;
        }

        private void toolStripMenuItemPrint_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;
            if(pageSetupDialog1.ShowDialog()==DialogResult.OK)
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Times New Roman", 14);
            Brush brush = Brushes.DarkBlue;
            Pen pen = new Pen(brush);

            PageSettings settings = printDocument1.DefaultPageSettings;
            var totalW=settings.PaperSize.Width-settings.Margins.Left-settings.Margins.Right;
            var totalH=settings.PaperSize.Height-settings.Margins.Top-settings.Margins.Bottom;

            if (settings.Landscape)
            {
                var temp = totalH;
                totalH = totalW;
                totalW = temp;
            }

            var cellW = totalW / 4;
            var cellH = 40;

            int x = settings.Margins.Left;
            int y = 100;

            graphics.DrawRectangle(pen, x, y, cellW, cellH);
            graphics.DrawRectangle(pen, x + cellW, y, cellW, cellH);
            graphics.DrawRectangle(pen, x + cellW * 2, y, cellW, cellH);
            graphics.DrawRectangle(pen, x + cellW * 3, y, cellW, cellH);

            //desenare text coloane
            graphics.DrawString("Meci", font, brush, x, y);
            graphics.DrawString("Pariu", font, brush, x + cellW, y);
            graphics.DrawString("Cota", font, brush, x + cellW * 2, y);
            graphics.DrawString("Ora meci", font, brush, x + cellW * 3, y);

            y += cellH;

            foreach(ListViewItem p in listViewBilet.Items)
            {
                graphics.DrawRectangle(pen, x, y, cellW, cellH);
                graphics.DrawRectangle(pen, x + cellW, y, cellW, cellH);
                graphics.DrawRectangle(pen, x + cellW * 2, y, cellW, cellH);
                graphics.DrawRectangle(pen, x + cellW * 3, y, cellW, cellH);

                graphics.DrawString(p.SubItems[0].Text, font, brush, x, y);
                graphics.DrawString(p.SubItems[1].Text, font, brush, x+cellW, y);
                graphics.DrawString(p.SubItems[2].Text, font, brush, x + 2 * cellW, y) ;
                graphics.DrawString(p.SubItems[3].Text, font, brush, x + 3 * cellW, y) ;

                y += cellH;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fm = new Form3();
            fm.Show();
        }

        private async void toolStripMenuItemSalveazaF_Click(object sender, EventArgs e)
        {
            SaveFileDialog cfg = new SaveFileDialog();
            cfg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (cfg.ShowDialog() == DialogResult.OK)
            {
                using (TextWriter tw = new StreamWriter(new FileStream(cfg.FileName, FileMode.Create), Encoding.UTF8)) 
                {
                    foreach (ListViewItem item in listViewBilet.Items)
                    {
                        await tw.WriteLineAsync(item.SubItems[0].Text + "\t" + item.SubItems[1].Text + "\t" + item.SubItems[2].Text + "\t" + item.SubItems[3].Text);
                    }
                    MessageBox.Show("Salvarea a avut loc cu succes!");
                }

            }

       }

        private void checkBoxNGG_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxP35_CheckedChanged(object sender, EventArgs e)
        {

        }
    }


}
    
    
    


