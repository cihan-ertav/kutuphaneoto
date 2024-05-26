using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane_otomasyon
{
    public partial class Form3 : Form
    {
       

        public Form3()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            

        }

        private int GetLatestKitapId()
        {
            string csvDosyaYolu = "C:\\Users\\Cihan\\gorsel_programlama\\kutuphane_otomasyon\\kutuphane_otomasyon\\bin\\Debug\\kitaplar.csv";
            // CSV dosyasını okuyun ve en son kitap ID'sini alın
            string[] satirlar = File.ReadAllLines(csvDosyaYolu);
            if (satirlar.Length > 0)
            {
                string sonSatir = satirlar[satirlar.Length - 1];
                string[] veriler = sonSatir.Split(';');
                int sonKitapId = int.Parse(veriler[0]);
                return sonKitapId;
            }
            else
            {
                // CSV dosyası boşsa veya hiç kitap yoksa 0 döndürün
                return 0;
            }
        }

        private void btnKaydetKitap_Click(object sender, EventArgs e)
        {
            
            Kitap yeniKitap = new Kitap();
            yeniKitap.kitap_İD = GetLatestKitapId()+ 1;
            yeniKitap.kitap_adi = textBox1.Text;
            yeniKitap.yazar_adi = textBox2.Text;
            yeniKitap.yayin_evi = textBox3.Text;
            yeniKitap.Kitap_turu = textBox4.Text;
            yeniKitap.Temin_tarihi = dateTimePicker1.Text;
            yeniKitap.Stok_sayisi = textBox6.Text;

            KitapBilgileriniCSVyeKaydet(yeniKitap);
            
        }
        public void KitapBilgileriniCSVyeKaydet(Kitap kitap)
        {
            string csvDosyaYolu = "C:\\Users\\Cihan\\gorsel_programlama\\kutuphane_otomasyon\\kutuphane_otomasyon\\bin\\Debug\\kitaplar.csv";

            // CSV dosyasını oluştur
            //if (!File.Exists(csvDosyaYolu))
            //{
            //    using (StreamWriter sw = File.CreateText(csvDosyaYolu))
            //    {
            //        // CSV dosyasının başlık satırını yaz
            //        string baslikSatiri = "ISBN,Baslik,Yazar";
            //        sw.WriteLine(baslikSatiri);
            //    }
            //}

            // Yeni kitap bilgilerini CSV dosyasına ekle
            
            using (StreamWriter sw = File.AppendText(csvDosyaYolu))
            {
                string kitapSatiri = $"{kitap.kitap_İD};{kitap.kitap_adi};{kitap.yazar_adi};{kitap.yayin_evi};{kitap.Kitap_turu};{kitap.Temin_tarihi};{kitap.Stok_sayisi}";
                sw.WriteLine(kitapSatiri);
            }
            MessageBox.Show("kitap kütüphaneye eklendi.");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = ""; 
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public class Kitap
    {
        public int kitap_İD { get; set; } 
        public string kitap_adi { get; set; }
        public string yazar_adi { get; set; }
        public string yayin_evi { get; set; }
        public string Kitap_turu { get; set; }
        public string Temin_tarihi { get; set; }
        public string Stok_sayisi { get; set; }

       
    }

}
