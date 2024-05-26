namespace kutuphane_otomasyon
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnEmanetKitaplar = new System.Windows.Forms.Button();
            this.btnKitapListe = new System.Windows.Forms.Button();
            this.btnOkuyucuListe = new System.Windows.Forms.Button();
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::kutuphane_otomasyon.Properties.Resources.books;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(552, 222);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 75);
            this.button1.TabIndex = 36;
            this.button1.Text = "Emanet ver";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCikis
            // 
            this.btnCikis.Image = global::kutuphane_otomasyon.Properties.Resources.close;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.Location = new System.Drawing.Point(423, 339);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(95, 75);
            this.btnCikis.TabIndex = 35;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnEmanetKitaplar
            // 
            this.btnEmanetKitaplar.Image = global::kutuphane_otomasyon.Properties.Resources.book_stack;
            this.btnEmanetKitaplar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmanetKitaplar.Location = new System.Drawing.Point(421, 222);
            this.btnEmanetKitaplar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmanetKitaplar.Name = "btnEmanetKitaplar";
            this.btnEmanetKitaplar.Size = new System.Drawing.Size(95, 75);
            this.btnEmanetKitaplar.TabIndex = 33;
            this.btnEmanetKitaplar.Text = "Emanet Kitaplar";
            this.btnEmanetKitaplar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmanetKitaplar.UseVisualStyleBackColor = true;
            this.btnEmanetKitaplar.Click += new System.EventHandler(this.btnEmanetKitaplar_Click);
            // 
            // btnKitapListe
            // 
            this.btnKitapListe.Image = global::kutuphane_otomasyon.Properties.Resources.library__1_;
            this.btnKitapListe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKitapListe.Location = new System.Drawing.Point(289, 222);
            this.btnKitapListe.Margin = new System.Windows.Forms.Padding(4);
            this.btnKitapListe.Name = "btnKitapListe";
            this.btnKitapListe.Size = new System.Drawing.Size(95, 75);
            this.btnKitapListe.TabIndex = 32;
            this.btnKitapListe.Text = "Kitap listesi";
            this.btnKitapListe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKitapListe.UseVisualStyleBackColor = true;
            this.btnKitapListe.Click += new System.EventHandler(this.btnKitapListe_Click);
            // 
            // btnOkuyucuListe
            // 
            this.btnOkuyucuListe.Image = global::kutuphane_otomasyon.Properties.Resources.group;
            this.btnOkuyucuListe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOkuyucuListe.Location = new System.Drawing.Point(552, 95);
            this.btnOkuyucuListe.Margin = new System.Windows.Forms.Padding(4);
            this.btnOkuyucuListe.Name = "btnOkuyucuListe";
            this.btnOkuyucuListe.Size = new System.Drawing.Size(95, 75);
            this.btnOkuyucuListe.TabIndex = 31;
            this.btnOkuyucuListe.Text = "Üye Listesi";
            this.btnOkuyucuListe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOkuyucuListe.UseVisualStyleBackColor = true;
            this.btnOkuyucuListe.Click += new System.EventHandler(this.btnOkuyucuListe_Click);
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.Image = global::kutuphane_otomasyon.Properties.Resources.user;
            this.btnUyeEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUyeEkle.Location = new System.Drawing.Point(423, 95);
            this.btnUyeEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(95, 75);
            this.btnUyeEkle.TabIndex = 30;
            this.btnUyeEkle.Text = "Üye Ekle";
            this.btnUyeEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUyeEkle.UseVisualStyleBackColor = true;
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Image = global::kutuphane_otomasyon.Properties.Resources.library;
            this.btnKitapEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKitapEkle.Location = new System.Drawing.Point(289, 95);
            this.btnKitapEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(95, 75);
            this.btnKitapEkle.TabIndex = 29;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 566);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnEmanetKitaplar);
            this.Controls.Add(this.btnKitapListe);
            this.Controls.Add(this.btnOkuyucuListe);
            this.Controls.Add(this.btnUyeEkle);
            this.Controls.Add(this.btnKitapEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "KÜTÜPHANE OTOMASYONU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.Button btnOkuyucuListe;
        private System.Windows.Forms.Button btnKitapListe;
        private System.Windows.Forms.Button btnEmanetKitaplar;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button button1;
    }
}

