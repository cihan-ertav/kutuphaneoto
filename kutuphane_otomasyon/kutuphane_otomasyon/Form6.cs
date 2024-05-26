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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void GuncelleAramaSonuclari(string arananMetin)
        {
            // Metin dosyasını oku ve her bir satırı string dizisine yükle
            string dosyaYolu = @"C:\Users\Cihan\gorsel_programlama\kutuphane_otomasyon\kutuphane_otomasyon\bin\Debug\kitaplar.csv";
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

        private void Form6_Load(object sender, EventArgs e)
        {
            YukeDataGridView2("C:\\Users\\Cihan\\gorsel_programlama\\kutuphane_otomasyon\\kutuphane_otomasyon\\bin\\Debug\\kitaplar.csv");
        }
        private void YukeDataGridView2(string dosyaYolu)
        {
            if (File.Exists(dosyaYolu))
            {
                // DataGridView'i temizleyin
                dataGridView1.Rows.Clear();

                // CSV dosyasını okuyun ve verileri DataGridView'e yükleyin



                string[] satirlar1 = File.ReadAllLines(dosyaYolu);

                string[] basliklar = satirlar1[0].Split(';');
                for (int i = 0; i < basliklar.Length; i++)
                {
                    dataGridView1.Columns.Add($"Column{i}", basliklar[i]);
                }

                for (int i = 1; i < satirlar1.Length; i++)
                {
                    string[] veri = satirlar1[i].Split(';');
                    dataGridView1.Rows.Add(veri);
                }
            }
        }

        private void btnUyeSil_Click(object sender, EventArgs e)
        {
           // int secilenid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = e.RowIndex;

            if (e.RowIndex >= 0) // Geçerli bir satırın seçildiğinden emin olun
            {

                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string kitap_adı = selectedRow.Cells[1].Value.ToString();
                string yazar_adı = selectedRow.Cells[2].Value.ToString();
                string yayin_evi = selectedRow.Cells[3].Value.ToString();
                string kitap_turu = selectedRow.Cells[4].Value.ToString();
                //string cinsiyet = selectedRow.Cells[5].Value.ToString();
                string stok_sayisi = selectedRow.Cells[6].Value.ToString();

                // İlgili formu oluşturun ve verileri aktarın
                Form11 form11 = new Form11(Id);
                form11.textBox1kitap.Text = kitap_adı;
                form11.textBox2yazar.Text = yazar_adı;
                form11.textBox3yayinev.Text = yayin_evi;
                form11.textBox4tur.Text = kitap_turu;
              //  form10.comboBox1cinsiyet.Text = cinsiyet;
                form11.textBox6sayi.Text = stok_sayisi;
                form11.Show();


            }
            GuncellUyeListesi();
        }

        private void GuncellUyeListesi()
        {
            string dosyaYolu = "kitaplar.csv";

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
