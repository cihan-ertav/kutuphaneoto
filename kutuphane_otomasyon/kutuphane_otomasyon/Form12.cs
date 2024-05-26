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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            //aaa();
        }

        private void aaa()
        {

            dataGridView1geciken.Rows.Clear();
            dataGridView1geciken.AutoGenerateColumns = false;

            // Emanetler.csv dosyasını okuyun
            string[] satirlar = File.ReadAllLines("emanetler.csv");

            // Geçerli tarih
            DateTime bugun = DateTime.Today;

            // Geçiken emanetleri saklamak için bir liste oluşturun
            List<string[]> gecikenEmanetler = new List<string[]>();






            // Her bir satırı kontrol edin
            foreach (string satir in satirlar)
            {
                string[] veriler = satir.Split(';');

                string tarihFormati = "dd.MM.yyyy";
                DateTime teslimTarihi11;

                // Teslim tarihi sütunundaki değeri DateTime olarak çevirin
                //DateTime teslimTarihi = DateTime.Parse(veriler[3]);

                // Teslim tarihi geçmişse ve teslim durumu "Teslim Edilmedi" ise,
                // emaneti gecikenEmanetler listesine ekleyin
                if (DateTime.TryParseExact(veriler[3], tarihFormati, CultureInfo.InvariantCulture, DateTimeStyles.None, out teslimTarihi11))
                {
                    if (teslimTarihi11 < bugun && veriler[6] == "Teslim Edilmedi")
                    {
                        gecikenEmanetler.Add(veriler);
                    }
                }
            }
            

            string[] basliklar = satirlar[0].Split(';');
            for (int i = 0; i < basliklar.Length; i++)
            {
                dataGridView1geciken.Columns.Add($"Column{i}", basliklar[i]);
            }

            foreach (string[] veriler in gecikenEmanetler)
            {
                dataGridView1geciken.Rows.Add(veriler);
            }
        }

        private void Form12_Shown(object sender, EventArgs e)
        {
            aaa();
        }
    }
}
