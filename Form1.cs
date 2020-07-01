using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace KelimeOyunu
{
    public partial class Form1 : Form
    {

        Veritabani[] vt = {
                            new VT4(), new VT4(), new VT5(), new VT5(),
                            new VT6(), new VT6(), new VT7(), new VT7(),
                            new VT8(), new VT8(), new VT9(), new VT9(),
                            new VT10(), new VT10()
        };

        string soru, cevap;
        Label[] cevapLabel; 

        int boslukSay = 0; 
        int puan;
        int kasa = 0;
        int soruSayısı = 0;

        public Form1()
        {
            InitializeComponent();
        }
        public void soruCevapCek()
        {
            if (soruSayısı < vt.Length)
            {
                soru = vt[soruSayısı].Soru();
                cevap = vt[soruSayısı].Cevap();
                richTextBoxSoru.Text = soru;
                cevapLabel = new Label[cevap.Length];
            }
            else
            {
                MessageBox.Show("Soru sayısını bitirdiniz.\nToplam puanınız : " + kasa);
                this.Close();
            }
            soruSayısı += 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            soruCevapCek();
            labelEkle(cevapLabel);
            labelYazdir(cevapLabel);
            puan = puanHesapla();
            labelPuan.Text = puan.ToString();
        }

        int sayac = 0; 
        private void buttonHarfAl_Click(object sender, EventArgs e)
        {
            int randomSayi = new Random().Next(cevap.Length);
            while (puan >= 0)
            {
                if (cevapLabel[randomSayi].Text == "-")
                {
                    cevapLabel[randomSayi].Text = cevap[randomSayi].ToString();
                    sayac = sayac + 1;
                    break;
                }
                else if (sayac == (cevap.Length - boslukSay))
                {
                    break;
                }
                else
                {
                    randomSayi = new Random().Next(cevap.Length);
                }
            }
            puan -= 100;
            if(puan >= 0)
                labelPuan.Text = puan.ToString();
            else
            {
                MessageBox.Show("Harfleri bitirdiniz");
                sayac = 0;
                soruCevapCek();
                labelEkle(cevapLabel);
                labelYazdir(cevapLabel);
                puan = puanHesapla();
            }
        }

        private void buttonCevapGir_Click(object sender, EventArgs e)
        {
            if (textBoxCevapGir.Text.ToLower() == cevap.ToLower() )
            {
                MessageBox.Show("Cevabınız Doğru");
                kasa += puan;
            }
            else { 
                MessageBox.Show("Cevabınız Yanlış");
                kasa -= puan;
                if (kasa < 0)
                    kasa = 0;
            }
            textBoxCevapGir.Text = "";
            sayac = 0;
            soruCevapCek();
            labelEkle(cevapLabel);
            labelYazdir(cevapLabel);
            puan = puanHesapla();
            labelKasaDeger.Text = kasa.ToString();
        }

        public int puanHesapla()
        {
            return (cevap.Length - boslukSay) * 100;
        }

        public void labelEkle(Label[] label)
        {
            int solaKay = 10;
            for (int i = 0; i < cevap.Length; i++)
            {
                label[i] = new Label();
                label[i].Left = richTextBoxSoru.Left + solaKay;
                solaKay += 50;
                label[i].Top = labelCevap.Top - 8;
                label[i].Width = 30;
                label[i].BackColor = Color.SkyBlue;
                this.Controls.Add(label[i]);
            }
        }




        public void labelYazdir(Label[] label)
        {
            for (int i = 0; i < label.Length; i++)
            {
                label[i].Text = "-"; 
                if (cevap[i].ToString() == " ")
                { 
                    label[i].Text = " ";
                    boslukSay += 1;
                }
            }
        }
    }
}
