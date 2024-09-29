using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saat_Uygulaması
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
            labelSn.Text = saniye.ToString();
            if(saniye == 60)
            {
                dakika++;
                labelDk.Text = dakika + ".";
                saniye = 0;

                if(dakika == 60)
                {
                    saat++;
                    labelSa.Text = saat + ".";
                    dakika = 0;

                    if(saat == 24)
                    {
                        saat = 0;
                        dakika= 0;
                        saniye = 0;
                        labelSa.Text= saat + ".";
                        labelDk.Text = dakika + ".";
                        labelSn.Text = saniye.ToString();

                    }
                }
            }
        }
    }
}
