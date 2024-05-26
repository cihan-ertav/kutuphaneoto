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
    public partial class Form11 : Form
    {
        int id;
        public Form11(int Id)
        {
            InitializeComponent();
            id = Id;
        }

        private void btnKaydetKitap_Click(object sender, EventArgs e)
        {
            string kitap = textBox1kitap.Text;
            string yazar = textBox2yazar.Text;
            string yayin_ev = textBox3yayinev.Text;
            string kitap_tur = textBox4tur.Text;
           
            string sayi = textBox6sayi.Text;


            bool guncellemeBasarili = UyeBilgileriniGuncelle(kitap, yazar, yayin_ev, kitap_tur, sayi);
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

        private bool UyeBilgileriniGuncelle(string kitap, string yazar, string yayin_ev, string kitap_tur, string sayi)
        {
            string dosyaYolu = "kitaplar.csv";
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
                        veriler[1] = kitap;
                        veriler[2] = yazar;
                        veriler[3] = yayin_ev;
                        veriler[4] = kitap_tur;
                      
                        veriler[6] = sayi;
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
