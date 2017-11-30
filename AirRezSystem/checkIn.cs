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
    public partial class checkIn : Form
    {
        public checkIn()
        {
            InitializeComponent();
        }
        public static string globalSelectSeat;
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            globalSelectSeat = ((PictureBox)sender).Name;
        }

        private void sA1_Click(object sender, EventArgs e)
        {
            foreach (PictureBox pb in this.Controls.OfType<PictureBox>())
            {

                ((PictureBox)pb).Image = Properties.Resources.lrseat;
            }
            sA1.Image = Properties.Resources.selectseat;
        }
        public void selectedSeat(object sender, EventArgs e)
        {
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ur'a Seat saved.Have a nice trip!");
            this.Close();

        }

        private void sB1_Click(object sender, EventArgs e)
        {
            foreach (PictureBox pb in this.Controls.OfType<PictureBox>())
            {

                ((PictureBox)pb).Image = Properties.Resources.lrseat;
            }
            sB1.Image = Properties.Resources.selectseat;
        }

        private void sC1_Click(object sender, EventArgs e)
        {
            foreach (PictureBox pb in this.Controls.OfType<PictureBox>())
            {

                ((PictureBox)pb).Image = Properties.Resources.lrseat;
            }
            sC1.Image = Properties.Resources.selectseat;
        }

        private void sA2_Click(object sender, EventArgs e)
        {
            foreach (PictureBox pb in this.Controls.OfType<PictureBox>())
            {

                ((PictureBox)pb).Image = Properties.Resources.lrseat;
            }
            sA2.Image = Properties.Resources.selectseat;
        }

        private void sB2_Click(object sender, EventArgs e)
        {
            foreach (PictureBox pb in this.Controls.OfType<PictureBox>())
            {

                ((PictureBox)pb).Image = Properties.Resources.lrseat;
            }
            sB2.Image = Properties.Resources.selectseat;
        }

        private void sC2_Click(object sender, EventArgs e)
        {
            foreach (PictureBox pb in this.Controls.OfType<PictureBox>())
            {

                ((PictureBox)pb).Image = Properties.Resources.lrseat;
            }
            sC2.Image = Properties.Resources.selectseat;
        }

      

        private void sD1_Click(object sender, EventArgs e)
        {
            foreach (PictureBox pb in this.Controls.OfType<PictureBox>())
            {

                ((PictureBox)pb).Image = Properties.Resources.lrseat;
            }
            sD1.Image = Properties.Resources.selectseat;
        }

        private void sE1_Click(object sender, EventArgs e)
        {
            foreach (PictureBox pb in this.Controls.OfType<PictureBox>())
            {

                ((PictureBox)pb).Image = Properties.Resources.lrseat;
            }
            sE1.Image = Properties.Resources.selectseat;
        }

        private void sF1_Click(object sender, EventArgs e)
        {
            foreach (PictureBox pb in this.Controls.OfType<PictureBox>())
            {

                ((PictureBox)pb).Image = Properties.Resources.lrseat;
            }
            sF1.Image = Properties.Resources.selectseat;
        }

        private void sD2_Click(object sender, EventArgs e)
        {
            foreach (PictureBox pb in this.Controls.OfType<PictureBox>())
            {

                ((PictureBox)pb).Image = Properties.Resources.lrseat;
            }
            sD2.Image = Properties.Resources.selectseat;
        }

        private void sE2_Click(object sender, EventArgs e)
        {
            foreach (PictureBox pb in this.Controls.OfType<PictureBox>())
            {

                ((PictureBox)pb).Image = Properties.Resources.lrseat;
            }
            sE2.Image = Properties.Resources.selectseat;
        }

        private void sF2_Click(object sender, EventArgs e)
        {
            foreach (PictureBox pb in this.Controls.OfType<PictureBox>())
            {

                ((PictureBox)pb).Image = Properties.Resources.lrseat;
            }
            sF2.Image = Properties.Resources.selectseat;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (PictureBox pb in this.Controls.OfType<PictureBox>())
            {

                ((PictureBox)pb).Image = Properties.Resources.lrseat;
            }
            
        }
    }
    /*
      foreach (PictureBox pb in this.Controls.OfType<PictureBox>())
            {
                ((PictureBox)pb).Image = Properties.Resources.lrseat;
            }
     */
}

