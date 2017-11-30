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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string[] businessPNR = { null, null, null, null, null };//Business yolcular için PNR oluşturuluyor
        public static string[] economyPNR = { null, null, null, null, null };//Economy yolcular için PNR oluşturuluyor
        public static bool[] business = { false, false, false, false, false };//Business yolcular için koltuk oluşturuluyor
        public static bool[] economy = { false, false, false, false, false };//Economy yolcular için koltuk oluşturuluyor
        public static int flEco, flBus, nowEco = economy.Length, nowBus = business.Length;//fl= Satın alınan biletler, now= Stok bilet sayısı

        public void pnrEco()//Random Num generator.
        {
            Random random = new Random();
            string chars = "ABCDEFGHIJKLMNOPRSTUVYZ123456789";
            string create = "";
            for (int i = 0; i < 6; i++)
            {
                create += chars[random.Next(chars.Length)];
            }
            economyPNR[flEco-1] = create.ToString();//PNR numarası array'e sırasına göre işleniyor.
        }
        public void pnrBus()//Random Num generator.
        {
            Random random = new Random();
            string chars = "ABCDEFGHIJKLMNOPRSTUVYZ123456789";
            string create = "";
            for (int i = 0; i < 6; i++)
            {
                create += chars[random.Next(chars.Length)];
            }
            businessPNR[flBus-1] = create.ToString();//PNR numarası array'e sırasına göre işleniyor.


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form pnr = new pnr();
            pnr.Show();
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form check = new pnrControl();
            check.Show();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (eco.Checked)
            {
                if (flEco == 5)//Bilet sayımı
                {
                   
                    MessageBox.Show("Sorry :( None Economy Seat's");

                }
                else
                {
                    economy[flEco] = true;//Gelen bilet sırası satışa göre sıralanıyor
                    flEco++;//Bilet sırası                    
                    nowEco--;//Görsel tasarımda ki stok biletler.
                    label1.Text = nowEco.ToString();
                    pnrEco();

                }

            }
            else if (bus.Checked)
            {
                if (flBus == 5)//Bilet sayımı
                {

                    MessageBox.Show("Sorry :( None Business Seat's");
                }
                else
                {
                    economy[flBus] = true;//Gelen bilet sırası satışa göre sıralanıyor
                    flBus++;//Bilet sırası
                    nowBus--;//Görsel tasarımda ki stok biletler.
                    label2.Text = nowBus.ToString();
                    pnrBus();
                }
            }
        }
    }
}
