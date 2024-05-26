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
    public partial class Form10 : Form
    {
        int id;
        public Form10(int Id)
        {
            InitializeComponent();

            id = Id;
        }

        private void btnKaydetKitap_Click(object sender, EventArgs e)
        {
            string yeni_tc=textBox1tc.Text;
            string yeni_ad=textBox2Ad.Text;
            string yeni_tel=textBox4tel.Text;
            string yeni_eposta=textBox6e_posta.Text;
            string yeni_cinsiyet=comboBox1cinsiyet.Text;
            string yeni_adres=textBox3adres.Text;


            bool guncellemeBasarili = UyeBilgileriniGuncelle(yeni_tc, yeni_ad, yeni_tel,yeni_eposta,yeni_cinsiyet,yeni_adres);
            if (guncellemeBasarili)
            {
                MessageBox.Show("Üye bilgileri güncellendi.");
                this.Close(); // Üye güncelleme formunu kapat
            }
            else
            {
                MessageBox.Show("Üye bilgileri güncellenirken bir hata oluştu.");
            }
        }


        private bool UyeBilgileriniGuncelle(string yeni_tc,string yeni_ad, string yeni_tel, string yeni_eposta, string yeni_cinsiyet, string yeni_adres)
        {
            string dosyaYolu = "üyeler.csv";
            try
            {
                string[] satirlar = File.ReadAllLines(dosyaYolu);

                for (int i = 0; i < satirlar.Length; i++)
                {
                    string satir = satirlar[i];
                    string[] veriler = satir.Split(';');

                    if (veriler[0] == id.ToString())
                    {
                        // Üye bilgilerini güncelle
                        veriler[1] = yeni_tc;
                        veriler[2] = yeni_ad;
                        veriler[4] = yeni_tel;
                        veriler[5]=yeni_eposta;
                        veriler[7]=yeni_cinsiyet;
                        veriler[8]=yeni_adres;
                        // Diğer güncellenmiş bilgileri ilgili indekslere yazın

                        // Güncellenen satiri oluştur
                        string guncellenenSatir = string.Join(";", veriler);

                        // Dosyadaki ilgili satiri güncelle
                        satirlar[i] = guncellenenSatir;

                        // Güncellenmiş satırları dosyaya yaz
                        File.WriteAllLines(dosyaYolu, satirlar);

                        return true; // Güncelleme başarılı oldu
                    }
                }

                return false; // Güncellenmek istenen üye bulunamadı
            }
            catch (Exception ex)
            {
                // Hata yönetimi için gerekli kodları ekleyin
                return false; // Güncelleme başarısız oldu
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
