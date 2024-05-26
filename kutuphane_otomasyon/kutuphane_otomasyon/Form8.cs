using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace kutuphane_otomasyon
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            YukeDataGridView1("C:\\Users\\Cihan\\gorsel_programlama\\kutuphane_otomasyon\\kutuphane_otomasyon\\bin\\Debug\\emanetler.csv");

        }


        private void YukeDataGridView1(string dosyaYolu)
        {
            if (File.Exists(dosyaYolu))
            {
                // DataGridView'i temizleyin
                dataGridView1.Rows.Clear();

                // CSV dosyasını okuyun ve verileri DataGridView'e yükleyin



                string[] satirlar = File.ReadAllLines(dosyaYolu);

                string[] basliklar = satirlar[0].Split(';');
                for (int i = 0; i < basliklar.Length; i++)
                {
                    dataGridView1.Columns.Add($"Column{i}", basliklar[i]);
                }

                for (int i = 1; i < satirlar.Length; i++)
                {
                    string[] veri = satirlar[i].Split(';');
                    dataGridView1.Rows.Add(veri);
                }

            }
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindx = e.RowIndex;

            if (e.RowIndex >= 0) // Geçerli bir satırın seçildiğinden emin olun
            {

                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string uyeAd = selectedRow.Cells[0].Value.ToString();
                string kitapAd = selectedRow.Cells[1].Value.ToString();

                // İlgili formu oluşturun ve verileri aktarın
                Form9 form2 = new Form9(rowindx);
                form2.textBox1UyeAd.Text = uyeAd;
                form2.textBox2kitapAd.Text = kitapAd;
                form2.Show();

                
            }
            GuncellemanetListesi();
        }
        private void GuncellemanetListesi()
        {
            dataGridView1.Rows.Clear();
            string dosyaYolu = "emanetler.csv";

            

            string[] satirlar = File.ReadAllLines(dosyaYolu);

            string[] basliklar = satirlar[0].Split(';');
            //for (int i = 0; i < basliklar.Length; i++)
            //{
            //    dataGridView1.Columns.Add($"Column{i}", basliklar[i]);
            //}

            for (int i = 1; i < satirlar.Length; i++)
            {
                string[] veri = satirlar[i].Split(';');
                dataGridView1.Rows.Add(veri);
            }
        }






        private void GuncelleAramaSonuclari(string arananMetin)
        {
            // Metin dosyasını oku ve her bir satırı string dizisine yükle
            string dosyaYolu = @"C:\Users\Cihan\gorsel_programlama\kutuphane_otomasyon\kutuphane_otomasyon\bin\Debug\emanetler.csv";
            string[] satirlar = File.ReadAllLines(dosyaYolu);

            // DataGridView satırlarını temizle
            dataGridView1.Rows.Clear();

            // Her bir satır için TextBox'taki kelimeleri ara
            for (int i = 1; i < satirlar.Length; i++) // 2. satırdan başlat
            {
                string satir = satirlar[i];
                bool kelimeBulundu = true;
                string[] kelimeler = arananMetin.Split(' ');

                foreach (string kelime in kelimeler)
                {
                    if (!satir.Contains(kelime))
                    {
                        kelimeBulundu = false;
                        break;
                    }
                }

                if (kelimeBulundu)
                {
                    string[] veriler = satir.Split(';');
                    dataGridView1.Rows.Add(veriler);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string arananMetin = textBox1.Text;
            GuncelleAramaSonuclari(arananMetin);
        }
    }
}
