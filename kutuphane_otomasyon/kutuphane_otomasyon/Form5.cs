using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace kutuphane_otomasyon
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        

        private void GuncelleAramaSonuclari(string arananMetin)
        {
            // Metin dosyasını oku ve her bir satırı string dizisine yükle
            string dosyaYolu = @"C:\Users\Cihan\gorsel_programlama\kutuphane_otomasyon\kutuphane_otomasyon\bin\Debug\üyeler.csv";
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

        private void Form5_Load(object sender, EventArgs e)
        {
             

            YukeDataGridView1("C:\\Users\\Cihan\\gorsel_programlama\\kutuphane_otomasyon\\kutuphane_otomasyon\\bin\\Debug\\üyeler.csv");

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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string arananMetin = textBox1.Text;
            GuncelleAramaSonuclari(arananMetin);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = e.RowIndex;

            if (e.RowIndex >= 0) // Geçerli bir satırın seçildiğinden emin olun
            {

                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string tc = selectedRow.Cells[1].Value.ToString();
                string Ad_soyad = selectedRow.Cells[2].Value.ToString();
                string telefon = selectedRow.Cells[4].Value.ToString();
                string e_posta = selectedRow.Cells[5].Value.ToString();
                string cinsiyet = selectedRow.Cells[7].Value.ToString();
                string adres = selectedRow.Cells[8].Value.ToString();

                // İlgili formu oluşturun ve verileri aktarın
                Form10 form10 = new Form10(Id);
                form10.textBox1tc.Text = tc;
                form10.textBox2Ad.Text = Ad_soyad;
                form10.textBox4tel.Text = telefon;
                form10.textBox6e_posta.Text = e_posta;
                form10.comboBox1cinsiyet.Text = cinsiyet;
                form10.textBox3adres.Text = adres;
                form10.Show();

                
            }
            GuncellUyeListesi();
        }
        private void GuncellUyeListesi()
        {
            string dosyaYolu = "üyeler.csv";
            
            dataGridView1.Rows.Clear();

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
}
