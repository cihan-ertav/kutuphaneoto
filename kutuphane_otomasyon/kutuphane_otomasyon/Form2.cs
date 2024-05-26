using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane_otomasyon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text;
            string sifre = textBox2.Text;

            // Kullanıcı adı ve şifreyi kontrol etmek için uygun bir mekanizma kullanın
            // Örneğin, basit bir kontrol için aşağıdaki if bloğunu kullanabilirsiniz
            if (kullaniciAdi == "chn" && sifre == "123")
            {
                // Form 2'ye geçiş yapmak için yeni bir Form 2 örneği oluşturun
                Form1 form1 = new Form1();

                // Form 2'yi gösterin ve Form 1'i gizleyin
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
