using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirRezSystem
{
    public partial class pnr : Form
    {
        public pnr()
        {
            InitializeComponent();
        }

        private void pnr_Load(object sender, EventArgs e)
        {





        }

        private void button1_Click(object sender, EventArgs e)
        {        
            for (int i = 0; i < Form1.economyPNR.Length; i++)
            {
                listBox1.Items.Add(Form1.economyPNR[i]);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.businessPNR.Length; i++)
            {
                listBox2.Items.Add(Form1.businessPNR[i]);

            }
        }
    }
}
