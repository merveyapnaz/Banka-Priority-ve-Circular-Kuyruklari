using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CircularArrayTypedQueue cq = new CircularArrayTypedQueue(20);
        PriorityQueue pqKB = new PriorityQueue(20);
        PriorityQueue pqBK = new PriorityQueue(20);
        Musteri[] musteri = new Musteri[20];
        Random random = new Random();
        int[] İlkBeklemeSureleri = new int[20];
        int[] SonBeklemeSureleriKB = new int[20];
        int[] SonBeklemeSureleriBK = new int[20];




        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                musteri[i] = new Musteri();
                musteri[i].MusteriNo = i + 1;
                musteri[i].IslemSuresi = random.Next(60, 600);
                cq.Insert(musteri[i]);
                pqKB.Insert(musteri[i]);
                pqBK.InsertBuyuktenKucuge(musteri[i]);
            }
        }

        private void btDaireselIslemTamamlanma_Click(object sender, EventArgs e)
        {
            txbDairesel.Text = "";
            int toplamBekleme = 0;
            Musteri m = new Musteri();
           
            for (int i = 0; i < 20; i++)
            {
                m = (Musteri)cq.Remove();
              
                toplamBekleme += m.IslemSuresi;
                İlkBeklemeSureleri[i] = toplamBekleme;
                txbDairesel.Text += "Müşteri No : " + m.MusteriNo + " İşlem Süresi : " + m.IslemSuresi.ToString() + " Kuyrukta Kaldığı Süre : " + toplamBekleme.ToString() + Environment.NewLine;


            }
            txbDairesel.Text += Environment.NewLine + "Ortalama İşlem Tamamlanma Süresi : " + (toplamBekleme / 20).ToString();
        }

        private void btKBSure_Click(object sender, EventArgs e)
        {
            txbOncelikli.Text = "";
            int toplamBekleme = 0;
            Musteri m = new Musteri();

            for (int i = 0; i < 20; i++)
            {
                m = (Musteri)pqKB.Remove();
                toplamBekleme += m.IslemSuresi;
                SonBeklemeSureleriKB[m.MusteriNo-1] = toplamBekleme;
                txbOncelikli.Text += "Müşteri No : " + m.MusteriNo + " İşlem Süresi : " + m.IslemSuresi.ToString() + " Kuyrukta Kaldığı Süre : " + toplamBekleme.ToString() + Environment.NewLine;


            }
            txbOncelikli.Text += Environment.NewLine + "Ortalama İşlem Tamamlanma Süresi : " + (toplamBekleme / 20).ToString();
        
        }

        private void btBKSure_Click(object sender, EventArgs e)
        {
            txbOncelikli.Text = "";
            int toplamBekleme = 0;
            Musteri m = new Musteri();

            for (int i = 0; i < 20; i++)
            {
                m = (Musteri)pqBK.Remove();
                toplamBekleme += m.IslemSuresi;
                SonBeklemeSureleriBK[m.MusteriNo-1] = toplamBekleme;
                txbOncelikli.Text += "Müşteri No : " + m.MusteriNo + " İşlem Süresi : " + m.IslemSuresi.ToString() + " Kuyrukta Kaldığı Süre : " + toplamBekleme.ToString() + Environment.NewLine;


            }
            txbOncelikli.Text += Environment.NewLine + "Ortalama İşlem Tamamlanma Süresi : " + (toplamBekleme / 20).ToString();
        }

        private void btKarsilastir_Click(object sender, EventArgs e)
        {
            txbOncelikli.Text = "";
            for (int i = 0; i < 20; i++)
            {
                if (SonBeklemeSureleriKB[i]<=İlkBeklemeSureleri[i])
                {
                    int sure = İlkBeklemeSureleri[i] - SonBeklemeSureleriKB[i];
                    txbOncelikli.Text += (i + 1).ToString() + " Nolu Müşterinin Bekleme Süresi Kazancı = " + sure.ToString()+ " Kazanç Yüzdesi %" + String.Format("{0:0.00}", ((SonBeklemeSureleriKB[i] * 100) / İlkBeklemeSureleri[i])) + Environment.NewLine;
                }
                
            }
        }

        private void btKarsilastirBK_Click(object sender, EventArgs e)
        {
            txbOncelikli.Text = "";
            for (int i = 0; i < 20; i++)
            {
                if (SonBeklemeSureleriBK[i] <= İlkBeklemeSureleri[i])
                {
                    int sure = İlkBeklemeSureleri[i] - SonBeklemeSureleriBK[i];
                    txbOncelikli.Text += (i + 1).ToString() + " Nolu Müşterinin Bekleme Süresi Kazancı = " + sure.ToString()+ " Kazanç Yüzdesi %" + String.Format("{0:0.00}", ((SonBeklemeSureleriBK[i] * 100) / İlkBeklemeSureleri[i])) + Environment.NewLine;
                }

            }
        }
    }
}
