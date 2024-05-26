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
    public partial class Form9 : Form
    {
        private int satirIndex;


        private string dosyaYolu = @"C:\Users\Cihan\gorsel_programlama\kutuphane_otomasyon\kutuphane_otomasyon\bin\Debug\emanetler.csv";
        private string kitaplarDosyaYolu = @"C:\Users\Cihan\gorsel_programlama\kutuphane_otomasyon\kutuphane_otomasyon\bin\Debug\kitaplar.csv";
        public Form9(int rowindx)
        {
            InitializeComponent();
            satirIndex = rowindx+1;

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            //GuncelleEmanetListesi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (satirIndex >= 0)
            {
                int rowIndex = satirIndex;
                GeriAlEmanet(rowIndex);
            }
            else
            {
                MessageBox.Show("Lütfen bir emanet seçin.");
            }
        }
        Form8 form8= new Form8();

        private void GuncelleEmanetListesi()
        {
            form8.dataGridView1.Rows.Clear();

            string[] satirlar = File.ReadAllLines(dosyaYolu);

            string[] basliklar = satirlar[0].Split(';');
            for (int i = 0; i < basliklar.Length; i++)
            {
                form8.dataGridView1.Columns.Add($"Column{i}", basliklar[i]);
            }

            foreach (string satir in satirlar)
            {
                string[] veriler = satir.Split(';');
                form8.dataGridView1.Rows.Add(veriler);
            }
        }

        private void GeriAlEmanet(int rowIndex)
        {
            string[] satirlar = File.ReadAllLines(dosyaYolu);

            if (rowIndex >=0 && rowIndex <= satirlar.Length)
            {
                string satir = satirlar[rowIndex];
                string[] veriler = satir.Split(';');

                veriler[4] = DateTime.Now.ToShortDateString();
                veriler[5] = comboBox1geri.Text; ;
                veriler[6] = "Teslim Edildi";

                string guncellenenSatir = string.Join(";", veriler);

                satirlar[rowIndex] = guncellenenSatir;

                File.WriteAllLines(dosyaYolu, satirlar);

                string kitapISBN = veriler[1];
                ArtirStokSayisi(kitapISBN);

                GuncelleEmanetListesi();

                MessageBox.Show("Emanet geri alındı ve stok güncellendi.");
            }
        }

        private void ArtirStokSayisi(string kitapISBN)
        {
            string[] kitapSatirlar = File.ReadAllLines(kitaplarDosyaYolu);

            for (int i = 0; i < kitapSatirlar.Length; i++)
            {
                string satir = kitapSatirlar[i];
                string[] veriler = satir.Split(';');

                if (veriler[0] == kitapISBN)
                {
                    int stokSayisi = int.Parse(veriler[3]);
                    stokSayisi++;
                    veriler[6] = stokSayisi.ToString();

                    string guncellenenSatir = string.Join(";", veriler);

                    kitapSatirlar[i] = guncellenenSatir;

                    File.WriteAllLines(kitaplarDosyaYolu, kitapSatirlar);
                    break;
                }
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            // GuncelleEmanetListesi();
            this.Close();
           
        }

        
    }
}
