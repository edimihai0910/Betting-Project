using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
        private void ReadInTimeSheet()
        {
            var fileLines = File.ReadAllLines(@"D:\Programare\C#\ProiectPAW\Pariuri.txt");

            for (int i = 0; i < fileLines.Length ; i+=2)
            {
                listViewPariuri.Items.Add(
                    new ListViewItem(new[]
                    {
                fileLines[i],
               fileLines[i+1],

                    }));
            }

            // Resize the columns
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ReadInTimeSheet();
        }
    }
}
