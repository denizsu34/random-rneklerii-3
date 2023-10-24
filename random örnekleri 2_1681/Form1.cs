using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_örnekleri_2_1681
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnÜret_Click(object sender, EventArgs e)
        {
            lbNotlar.Items.Clear();
            Random rnd = new Random();

            for (int i = 0; i < 15; i++)
            {
                int puan = rnd.Next(0, 100);
                lbNotlar.Items.Add(puan);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kaldı = 0, duz = 0, tesekur = 0,takdir =0;

            for (int i = 0; i < lbNotlar.Items.Count; i++)
            {
                int puan = Convert.ToInt32(lbNotlar.Items[i]);// İ.sıradaki notu alır.

                if (puan < 50)
                {
                    kaldı++;
                }
                else if (puan >= 50 && puan < 80)
                {
                    duz++;
                }
                else if (puan >= 50 && puan < 90)
                {
                    tesekur++;
                }
                else
                {
                    takdir++;
                }
            }
            lblKalan.Text = "kalan öğrenci:" + Convert.ToString(kaldı);
            lblDuz.Text = "düz geçen öğrenci sayısı:" + Convert.ToString(duz);
            lblTaktir.Text = "taktir sayısı:" + Convert.ToString(takdir);
            lblTesekur.Text ="teşekkur sayısı:" + Convert.ToString(tesekur);
            
        }
    }
}
