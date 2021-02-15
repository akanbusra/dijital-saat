using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_ile_dijital_saat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saniye = 0, dakika = 0, saat = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            lblsaniye.Text = saniye.ToString();

            if (saniye==60)
            {
                dakika++;
                lbldakika.Text = dakika.ToString();
                saniye = 0;

                if (dakika==60)
                {
                    saat++;
                    lblsaat.Text = saat.ToString();
                    dakika = 0;
                }
            }
        }
    }
}
