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
    public partial class pnrControl : Form
    {
        public pnrControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.economyPNR.Length; i++)
            {
                if (textBox1.Text == Form1.economyPNR[i].ToString())
                {
                    this.Close();
                    Form checkin = new checkIn();
                    checkin.ShowDialog();
                    return;
                }
                else if (textBox1.Text == Form1.businessPNR[i].ToString())
                {
                    this.Close();
                    Form checkin = new checkIn();
                    checkin.ShowDialog();
                    return;
                }
                else
                {
                    label1.Text = "Wrong PNR.";

                }
                
            }
        }
    }
}
