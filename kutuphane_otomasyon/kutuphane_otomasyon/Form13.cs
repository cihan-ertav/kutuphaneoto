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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        private string kitaplarDosyaYolu = "kitaplar.csv";
        private string emanetlerDosyaYolu = "emanetler.csv";

        private void Form13_Load(object sender, EventArgs e)
        {
            EnCokOkunanKitapListesiRaporu();
        }

        private List<string[]> DosyadanVerileriOku(string dosyaYolu)
        {
            List<string[]> veriler = new List<string[]>();

            // Dosya varsa okuma işlemini gerçekleştirin
            if (File.Exists(dosyaYolu))
            {
                string[] satirlar = File.ReadAllLines(dosyaYolu);

                foreach (string satir in satirlar)
                {
                    string[] veri = satir.Split(';');
                    veriler.Add(veri);
                }
            }

            return veriler;
        }

        private void EnCokOkunanKitapListesiRaporu()
        {
            // Kitaplar.csv dosyasından verileri okuyun
            List<string[]> kitapVerileri = DosyadanVerileriOku("kitaplar.csv");

            // Okuma sayılarına göre kitapları gruplayın
            var gruplanmisKitaplar = kitapVerileri
                .GroupBy(veri => veri[5]) // Okuma sayısı sütunu
                .Select(grup => new { KitapAdi = grup.Key, OkumaSayisi = grup.Count() })
                .OrderByDescending(item => item.OkumaSayisi)
                .ToList();

            // DataGridView'i temizleyin
            dataGridView1.Rows.Clear();

            // Gruplanmış kitapları DataGridView'e ekleyin
            foreach (var kitap in gruplanmisKitaplar)
            {
                dataGridView1.Rows.Add(kitap.KitapAdi, kitap.OkumaSayisi);
            }
        }



    }
}
