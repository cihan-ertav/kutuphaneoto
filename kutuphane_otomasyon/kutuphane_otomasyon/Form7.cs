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
using System.Globalization;

namespace kutuphane_otomasyon
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            YukeDataGridView1("C:\\Users\\Cihan\\gorsel_programlama\\kutuphane_otomasyon\\kutuphane_otomasyon\\bin\\Debug\\üyeler.csv");
            YukeDataGridView2("C:\\Users\\Cihan\\gorsel_programlama\\kutuphane_otomasyon\\kutuphane_otomasyon\\bin\\Debug\\kitaplar.csv");
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

        private void YukeDataGridView2(string dosyaYolu)
        {
            if (File.Exists(dosyaYolu))
            {
                // DataGridView'i temizleyin
                dataGridView2.Rows.Clear();

                // CSV dosyasını okuyun ve verileri DataGridView'e yükleyin



                string[] satirlar1 = File.ReadAllLines(dosyaYolu);

                string[] basliklar = satirlar1[0].Split(';');
                for (int i = 0; i < basliklar.Length; i++)
                {
                    dataGridView2.Columns.Add($"Column{i}", basliklar[i]);
                }

                for (int i = 1; i < satirlar1.Length; i++)
                {
                    string[] veri = satirlar1[i].Split(';');
                    dataGridView2.Rows.Add(veri);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tıklanan satırın indeksini alın
            int rowIndex = e.RowIndex;

            // Eğer geçerli bir satır tıklandıysa
            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
            {
                //İlgili satırdaki ismi TextBox'a gösterin
                textBox1.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();


            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tıklanan satırın indeksini alın
            int rowIndex = e.RowIndex;

            // Eğer geçerli bir satır tıklandıysa
            if (rowIndex >= 0 && rowIndex < dataGridView2.Rows.Count)
            {
                //İlgili satırdaki ismi TextBox'a gösterin
                textBox2.Text = dataGridView2.Rows[rowIndex].Cells[1].Value.ToString();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Lütfen üye ve kitap seçimi yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

            // Seçilen üye ve kitap bilgilerini alın
           // string uyeId = dataGridView1.SelectedRows[2].Cells[1].Value.ToString();
            string uyeAdi = textBox1.Text;
            string kitapAdi = textBox2.Text;

            // Kitap stok sayısını kontrol edin
            int stokSayisi = GetKitapStokSayisi(kitapAdi);

            if (stokSayisi <= 0)
            {
                MessageBox.Show("Seçilen kitap stokta bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Emanet verme tarihini ve teslim tarihini alın
            DateTime emanetTarihi = DateTime.Now;
            DateTime sonteslimTarihi = dateTimePicker1.Value;

            // Yeni emanet veri kaydını oluşturun
            string[] emanetVeri = { /*uyeId.*/ uyeAdi, kitapAdi, emanetTarihi.ToString(), sonteslimTarihi.ToString() };

            // Emanet veri kaydını DataGridView2'ye ekleyin

            String csvdosyayolu = "emanetler.csv";

            // CSV dosyasını oluştur
            if (!File.Exists(csvdosyayolu))
            {
                using (StreamWriter sw = File.CreateText(csvdosyayolu))
                {
                    // CSV dosyasının başlık satırını yaz
                    string baslikSatiri = "Üye Adı;Kitap Adı;Emanet Tarihi;Son Teslim Tarihi;Teslim Tarihi;Hasar Durumu;Teslim Durumu";
                    sw.WriteLine(baslikSatiri);
                }
            }

            // Yeni kitap bilgilerini CSV dosyasına ekle
            string hasar_durumu = "";
            string teslim_durumu = "Teslim Edilmedi";
            string teslim_tarihi = "";
            using (StreamWriter sw = File.AppendText(csvdosyayolu))
            {
                string uyeSatiri = $"{uyeAdi};{kitapAdi};{emanetTarihi};{sonteslimTarihi};{teslim_tarihi};{hasar_durumu};{teslim_durumu}";
                sw.WriteLine(uyeSatiri);
            }






            // Kitap stok sayısını bir azaltın
            UpdateKitapStokSayisi(kitapAdi, stokSayisi - 1);

            // Başarılı bir şekilde emanet verildiğini kullanıcıya bildirin
            MessageBox.Show("Emanet verme işlemi başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void UpdateKitapStokSayisi(string kitapAdi, int yeniStokSayisi)
        {
            string csvFilePath = "kitaplar.csv";
            List<string> lines = new List<string>();

            // CSV dosyasını satır satır okuyarak güncel stok sayısını yazın
            using (StreamReader reader = new StreamReader(csvFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split(';');

                    // Kitap adını kontrol edin
                    if (fields.Length >= 2 && fields[1] == kitapAdi)
                    {
                        fields[6] = yeniStokSayisi.ToString(); // Stok sayısını güncelle

                        line = string.Join(";", fields); // Güncellenmiş satırı birleştir

                        // Eğer stok sayısı sıfır ise emanet verme işlemi yapılamaz
                        if (yeniStokSayisi == -1)
                        {
                            MessageBox.Show("Seçilen kitap stokta bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    lines.Add(line);
                }
            }

            // Güncellenmiş verileri CSV dosyasına yazın
            using (StreamWriter writer = new StreamWriter(csvFilePath))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
            }
        }

        private int GetKitapStokSayisi(string kitapAdi)
        {
            string csvFilePath = "kitaplar.csv";

            // CSV dosyasını satır satır okuyarak kitap stok sayısını bulun
            using (StreamReader reader = new StreamReader(csvFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split(';');

                    // Kitap adını kontrol edin
                    if (fields.Length >= 2 && fields[1] == kitapAdi)
                    {
                        int stokSayisi;
                        if (int.TryParse(fields[6], out stokSayisi))
                        {
                            return stokSayisi; // Stok sayısını döndür
                        }
                        else
                        {
                            MessageBox.Show("Kitap stok sayısı geçersiz bir değer içeriyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return 0;
                        }
                    }
                }
            }

            MessageBox.Show("Seçilen kitap bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 0;
        }

        
    }
}
