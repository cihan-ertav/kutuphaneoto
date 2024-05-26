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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string phoneNumber = textBox4.Text;

            // Girilen metindeki gereksiz karakterleri kaldırma
            phoneNumber = new string(phoneNumber.Where(char.IsDigit).ToArray());

            // Telefon numarasını uygun formata getirme
            if (phoneNumber.Length > 0)
            {
                phoneNumber = string.Format("{0:(###)-###-####}", double.Parse(phoneNumber));
            }

            textBox4.Text = phoneNumber;
            textBox4.SelectionStart = phoneNumber.Length; // Cursor pozisyonunu metnin sonuna getirme
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //MaskedTextBox maskedTextBoxEmail = new MaskedTextBox();
            //maskedTextBoxEmail.Mask = "AAAAA@AAAAA.AAA";
        }

        
        
        
        public void UyeBilgileriniCSVyeKaydet(Uye Uye)
        {
            string csvDosyaYolu = "üyeler.csv";

           // CSV dosyasını oluştur
            if (!File.Exists(csvDosyaYolu))
            {
                using (StreamWriter sw = File.CreateText(csvDosyaYolu))
                {
                    // CSV dosyasının başlık satırını yaz
                    string baslikSatiri = "ID;Üye TC;Adı Soyadı;doğum Tarihi;Telefon;e-posta;Üyelik Tarihi;Cinsiyet;Adres";
                    sw.WriteLine(baslikSatiri);
                }
            }

           // Yeni kitap bilgilerini CSV dosyasına ekle

            using (StreamWriter sw = File.AppendText(csvDosyaYolu))
            {
                string uyeSatiri = $"{Uye.uye_İD};{Uye.uye_TC};{Uye.uye_adi_soyadi};{Uye.dogum_tarihi};{Uye.telefon};{Uye.e_posta};{Uye.uyelik_tarihi};{Uye.cinsiyet};{Uye.adres}";
                sw.WriteLine(uyeSatiri);
            }
            MessageBox.Show("Üye eklendi.");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            //textBox5.Text = "";
            textBox6.Text = "";
        }

        private int GetLatestKitapId()
        {
            string csvDosyaYolu = "C:\\Users\\Cihan\\gorsel_programlama\\kutuphane_otomasyon\\kutuphane_otomasyon\\bin\\Debug\\üyeler.csv";
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



        private void btnKaydetKitap_Click_1(object sender, EventArgs e)
        {
            Uye yeniUye = new Uye();
            yeniUye.uye_İD = GetLatestKitapId() + 1;
            yeniUye.uye_TC = textBox1.Text;
            yeniUye.uye_adi_soyadi = textBox2.Text;
            yeniUye.dogum_tarihi = dateTimePicker2.Text;
            yeniUye.telefon = textBox4.Text;
            yeniUye.e_posta = textBox6.Text;
            yeniUye.uyelik_tarihi = dateTimePicker1.Text;
            yeniUye.cinsiyet = comboBox1.Text;
            yeniUye.adres = textBox3.Text;

            UyeBilgileriniCSVyeKaydet(yeniUye);
            
        }

        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
    public class Uye
    {
        public int uye_İD { get; set; }
        public string uye_TC { get; set; }
        public string uye_adi_soyadi { get; set; }
        public string dogum_tarihi { get; set; }
        public string telefon { get; set; }
        public string e_posta { get; set; }
        public string uyelik_tarihi { get; set; }
        public string cinsiyet { get; set; }
        public string adres { get; set; }

        // Kitap yeni_kitap= new Kitap();


        // Diğer özellikler
    }

}

