using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphLibrary;

namespace ProiectPAW
{
  
    public partial class Form4 : Form
    {
        List<BarValue> values;
        public Form4(List<Bilet> bilet)
        {
            values = new List<BarValue>();
            foreach(Bilet b in bilet)
            {
                values.Add(new BarValue(b.nrMeciuri, b.id.ToString())) ;
            }
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            userControl11.values = values;
           
        }
    }
}
